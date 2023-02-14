using NUnit.Framework;
using RestSharp;
using RestSharpTemplate.Bases;
using RestSharpTemplate.Requests.PetStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTemplate.Tests
{
    [TestFixture]
    public class PetTests : TestBase
    {

        [Test]
        public void AdicionarPetTest()
        {
            string statusCodeEsperado = "OK";

            AddPetRequest addPetRequest = new AddPetRequest();
            addPetRequest.setJsonBody();
            IRestResponse<dynamic> response = addPetRequest.ExecuteRequest();

            Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
        }



    }
}
