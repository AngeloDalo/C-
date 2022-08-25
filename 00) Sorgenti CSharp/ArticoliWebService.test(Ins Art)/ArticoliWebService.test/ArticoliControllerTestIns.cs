using System;
using System.Collections.Generic;
using ArticoliWebService.Controllers;
using ArticoliWebService.Models;
using ArticoliWebService.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace ArticoliWebService.test
{
    public class ArticoliControllerTestIns
    {
        private Articoli CreateArtTest()
        {
            // Creazione Articolo
            var Articolo = new Articoli() {CodArt = "123ProvaIns", Descrizione = "Articolo Test Inserimento", 
                Um = "PZ", CodStat = "TESTART", PzCart = 6, PesoNetto = 1.750, IdIva = 10, IdFamAss = 1, 
                IdStatoArt = "1", DataCreazione = DateTime.Today};

            //Creazione Barcode 
            List<Ean> Barcodes = new List<Ean>();
            var Barcode = new Ean {CodArt="123ProvaIns", Barcode = "85698742", IdTipoArt = "CP"};
            Barcodes.Add(Barcode);

            //Passiamo il Barcode all'Articolo
            Articolo.barcode = Barcodes;

            return Articolo;
        }


        [Fact]
        public void TestSaveArticolo()
        {
             // Arrange
            var dbContext = DbContextMocker.alphaShopDbContext();
            var controller = new ArticoliController(new ArticoliRepository(dbContext));

            // Act
            var response = controller.SaveArticoli(this.CreateArtTest()) as ObjectResult;
            var value = response.Value as InfoMsg;

            dbContext.Dispose();

            // Assert
            Assert.Equal(200, response.StatusCode);
            Assert.NotNull(value);
            Assert.Equal("Inserimento articolo 123ProvaIns eseguita con successo!", value.Message);
        }

        [Fact]
        public void TesErrSaveArticolo()
        {
             // Arrange
            var dbContext = DbContextMocker.alphaShopDbContext();
            var controller = new ArticoliController(new ArticoliRepository(dbContext));

            // Act
            var response = controller.SaveArticoli(this.CreateArtTest()) as ObjectResult;
            var value = response.Value as InfoMsg;

            dbContext.Dispose();

            // Assert
            Assert.Equal(422, response.StatusCode);
            Assert.NotNull(value);
            Assert.Equal("Articolo 123ProvaIns presente in anagrafica! Impossibile utilizzare il metodo POST!", value.Message);
        }

        [Fact]
        public void TesUpdArticolo()
        {
            // Arrange
            var dbContext = DbContextMocker.alphaShopDbContext();
            var controller = new ArticoliController(new ArticoliRepository(dbContext));

            Articoli articolo = this.CreateArtTest();
            articolo.Descrizione = "Articolo Test Inserimento Modificato";

            // Act
            var response = controller.UpdateArticoli(articolo) as ObjectResult;
            var value = response.Value as InfoMsg;

            dbContext.Dispose();

             // Assert
            Assert.Equal(200, response.StatusCode);
            Assert.NotNull(value);
            Assert.Equal("Modifica articolo 123ProvaIns eseguita con successo!", value.Message);
        }

        [Fact]
        public void TestDelArticolo()
        {
             // Arrange
            var dbContext = DbContextMocker.alphaShopDbContext();
            var controller = new ArticoliController(new ArticoliRepository(dbContext));

            // Act
            var response = controller.DeleteArticoli("123ProvaIns") as ObjectResult;
            var value = response.Value as InfoMsg;

            dbContext.Dispose();

             // Assert
            Assert.Equal(200, response.StatusCode);
            Assert.NotNull(value);
            Assert.Equal("Eliminazione articolo 123ProvaIns eseguita con successo!", value.Message);

        }
    }
}