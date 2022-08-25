using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("api/saluti")]
    public class SalutiController
    {
        [HttpGet]
        public string getSaluti()
        {
            return "Saluti, sono il tuo primo web service creato con c#";
        }

        [HttpGet("{Nome}")]
        public string getSaluti2(string Nome) =>
            string.Format("\"Saluti, {0} sono il tuo primo web service creato con c#\"", Nome);

        
    }
}