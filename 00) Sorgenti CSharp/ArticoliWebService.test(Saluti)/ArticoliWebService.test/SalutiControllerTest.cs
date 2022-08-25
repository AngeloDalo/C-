using Controllers;
using Xunit;

namespace ArticoliWebService.test
{
    public class SalutiControllerTest
    {
        SalutiController salutiController;

        public SalutiControllerTest()
        {
            salutiController = new SalutiController();
        }

        [Fact]
        public void testGetSaluti()
        {
            string retVal = salutiController.getSaluti();

            Assert.Equal("Saluti, sono il tuo primo web service creato con c#", retVal);
        }

        [Fact]
        public void testGetSaluti2()
        {
            string retVal = salutiController.getSaluti2("Nicola");

            Assert.Equal("\"Saluti, Nicola sono il tuo primo web service creato con c#\"", retVal);
        }

        [Fact]
        public void testGetSaluti2Err()
        {
            string retVal = salutiController.getSaluti2("Marco");

            Assert.Equal("\"Errore: L'utente Marco è disabilitato!\"", retVal);
        }
    }
}