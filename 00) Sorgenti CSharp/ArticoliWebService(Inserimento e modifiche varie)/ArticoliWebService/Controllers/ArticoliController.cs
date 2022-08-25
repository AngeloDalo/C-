using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ArticoliWebService.Dtos;
using ArticoliWebService.Models;
using ArticoliWebService.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArticoliWebService.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/articoli")]
    public class ArticoliController : Controller
    {
        private readonly IArticoliRepository articolirepository;

        public ArticoliController(IArticoliRepository articolirepository)
        {
            this.articolirepository = articolirepository;
        }

        [HttpGet("cerca/descrizione/{filter}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ArticoliDto>))]
        public async Task<IActionResult> GetArticoliByDesc(string filter)
        {
            var articoliDto = new List<ArticoliDto>();

            var articoli = await this.articolirepository.SelArticoliByDescrizione(filter);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (articoli.Count == 0)
            {
                return NotFound(string.Format("Non è stato trovato alcun articolo con il filtro '{0}'", filter));
            }

            foreach(var articolo in articoli)
            {
                articoliDto.Add(new ArticoliDto
                {
                    CodArt = articolo.CodArt,
                    Descrizione = articolo.Descrizione,
                    Um = articolo.Um,
                    CodStat = articolo.CodStat,
                    PzCart = articolo.PzCart,
                    PesoNetto = articolo.PesoNetto,
                    DataCreazione = articolo.DataCreazione,
                    IdStatoArt = articolo.IdStatoArt,
                    Categoria = (articolo.famAssort != null) ? articolo.famAssort.Descrizione : null
                });
            }

            return Ok(articoliDto);
        }

        private ArticoliDto CreateArticoloDTO(Articoli articolo)
        {
            var barcodeDto = new List<BarcodeDto>();
            
            foreach(var ean in articolo.barcode)
            {
                barcodeDto.Add(new BarcodeDto
                {
                    Barcode = ean.Barcode,
                    Tipo = ean.IdTipoArt
                });
            }

            var articoliDto = new ArticoliDto
            {
                CodArt = articolo.CodArt,
                Descrizione = articolo.Descrizione,
                Um = (articolo.Um != null) ? articolo.Um.Trim() : "",
                CodStat = (articolo.CodStat != null) ? articolo.CodStat.Trim() : "", 
                PzCart = articolo.PzCart,
                PesoNetto = articolo.PesoNetto,
                DataCreazione = articolo.DataCreazione,
                Ean = barcodeDto,
                IdFamAss = articolo.IdFamAss,
                IdStatoArt = (articolo.IdStatoArt != null) ? articolo.IdStatoArt.Trim() : "",
                IdIva = articolo.IdIva,
                Categoria = (articolo.famAssort != null) ? articolo.famAssort.Descrizione : "Non Definito"
            };

            return articoliDto;
        }

        [HttpGet("cerca/codice/{CodArt}", Name = "GetArticoli")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(ArticoliDto))]
        public async Task<IActionResult> GetArticoloByCode(string CodArt)
        {
            if (!await this.articolirepository.ArticoloExists(CodArt))
            {
                return NotFound(string.Format("Non è stato trovato l'articolo con il codice '{0}'", CodArt));
            }

            var articolo = await this.articolirepository.SelArticoloByCodice(CodArt);

            return Ok(CreateArticoloDTO(articolo));
        }

        [HttpGet("cerca/barcode/{Ean}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(ArticoliDto))]
        public async Task<IActionResult> GetArticoloByEan(string Ean)
        {
            var articolo = await this.articolirepository.SelArticoloByEan(Ean);

            if (articolo == null)
            {
                return NotFound(string.Format("Non è stato trovato l'articolo con il barcode '{0}'", Ean));
            }

	        return Ok(CreateArticoloDTO(articolo));
            
        }

        [HttpPost("inserisci")]
        [ProducesResponseType(201, Type = typeof(Articoli))]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        [ProducesResponseType(500)]
        public IActionResult SaveArticoli([FromBody] Articoli articolo)
        {
            if (articolo == null)
            {
                return BadRequest(ModelState);
            }

             //Verifichiamo che i dati siano corretti
            if (!ModelState.IsValid)
            {
                string ErrVal = "";

                foreach (var modelState in ModelState.Values) 
                {
                    foreach (var modelError in modelState.Errors) 
                    {
                        ErrVal += modelError.ErrorMessage + " - "; 
                    }
                }

                return BadRequest(new InfoMsg(DateTime.Today, ErrVal));
            }

            //Contolliamo se l'articolo è presente
            var isPresent = articolirepository.SelArticoloByCodice2(articolo.CodArt);

            if (isPresent != null)
            {
                //ModelState.AddModelError("", $"Articolo {articolo.CodArt} presente in anagrafica! Impossibile utilizzare il metodo POST!");
                return StatusCode(422, new InfoMsg(DateTime.Today, $"Articolo {articolo.CodArt} presente in anagrafica! Impossibile utilizzare il metodo POST!"));
            }

            
            articolo.DataCreazione = DateTime.Today;
            
            //verifichiamo che i dati siano stati regolarmente inseriti nel database
            if (!articolirepository.InsArticoli(articolo))
            {
                //ModelState.AddModelError("", $"Ci sono stati problemi nell'inserimento dell'Articolo {articolo.CodArt}.  ");
                return StatusCode(500, new InfoMsg(DateTime.Today, $"Ci sono stati problemi nell'inserimento dell'Articolo {articolo.CodArt}."));
            }

            //return CreatedAtRoute("GetArticoli", new {codart = articolo.CodArt}, CreateArticoloDTO(articolo));

            return Ok(new InfoMsg(DateTime.Today, $"Inserimento articolo {articolo.CodArt} eseguita con successo!"));
        }

        [HttpPut("modifica")]
        [ProducesResponseType(201, Type = typeof(InfoMsg))]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        [ProducesResponseType(500)]
        public IActionResult UpdateArticoli([FromBody] Articoli articolo)
        {
            if (articolo == null)
            {
                return BadRequest(ModelState);
            }

             //Verifichiamo che i dati siano corretti
            if (!ModelState.IsValid)
            {
                string ErrVal = "";

                foreach (var modelState in ModelState.Values) 
                {
                    foreach (var modelError in modelState.Errors) 
                    {
                        ErrVal += modelError.ErrorMessage + " - "; 
                    }
                }

                return BadRequest(new InfoMsg(DateTime.Today, ErrVal));
            }

            //Contolliamo se l'articolo è presente (Usare il metodo senza Traking)
            var isPresent = articolirepository.SelArticoloByCodice2(articolo.CodArt);

            if (isPresent == null)
            {
                //ModelState.AddModelError("", $"Articolo {articolo.CodArt} NON presente in anagrafica! Impossibile utilizzare il metodo PUT!");
                return StatusCode(422, new InfoMsg(DateTime.Today, $"Articolo {articolo.CodArt} NON presente in anagrafica! Impossibile utilizzare il metodo PUT!"));
            }
            

            //verifichiamo che i dati siano stati regolarmente inseriti nel database
            if (!articolirepository.UpdArticoli(articolo))
            {
                //ModelState.AddModelError("", $"Ci sono stati problemi nella modifica dell'Articolo {articolo.CodArt}.  ");
                return StatusCode(500, new InfoMsg(DateTime.Today, $"Ci sono stati problemi nella modifica dell'Articolo {articolo.CodArt}.  "));
            }

            return Ok(new InfoMsg(DateTime.Today, $"Modifica articolo {articolo.CodArt} eseguita con successo!"));

        }

        [HttpDelete("elimina/{codart}")]
        [ProducesResponseType(201, Type = typeof(InfoMsg))]
        [ProducesResponseType(400, Type = typeof(InfoMsg))]
        [ProducesResponseType(422, Type = typeof(InfoMsg))]
        [ProducesResponseType(500)]
        public IActionResult DeleteArticoli(string codart)
        {
            if (codart == "")
            {
                return BadRequest(new InfoMsg(DateTime.Today, $"E' necessario inserire il codice dell'articolo da eliminare!"));
            }

            //Contolliamo se l'articolo è presente (Usare il metodo senza Traking)
            var articolo = articolirepository.SelArticoloByCodice2(codart);

            if (articolo == null)
            {
                return StatusCode(422, new InfoMsg(DateTime.Today, $"Articolo {codart} NON presente in anagrafica! Impossibile Eliminare!"));
            }

            //verifichiamo che i dati siano stati regolarmente eliminati dal database
            if (!articolirepository.DelArticoli(articolo))
            {
                //ModelState.AddModelError("", $"Ci sono stati problemi nella eliminazione dell'Articolo {articolo.CodArt}.  ");
                return StatusCode(500, new InfoMsg(DateTime.Today, $"Ci sono stati problemi nella eliminazione dell'Articolo {articolo.CodArt}.  "));
            }

            return Ok(new InfoMsg(DateTime.Today, $"Eliminazione articolo {codart} eseguita con successo!"));

        }






    }
}