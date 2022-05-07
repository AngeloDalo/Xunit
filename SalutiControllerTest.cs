using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalutiWebApi2.Controllers;
using Xunit;

namespace SalutiWebApi.test
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
            string testVal = "\"Saluti, sono la tua prima web api creata in c#\"";

            Assert.Equal(testVal, retVal);
        }

        [Fact]
        public void testGetSaluti2()
        {
            string retVal = salutiController.getSaluti("Nicola");
            string testVal = "\"Saluti, Nicola sono il tuo primo web service creato con C# 5.0\"";

            Assert.Equal(testVal, retVal);
        }
    }
}