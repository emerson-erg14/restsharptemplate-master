using RestSharp;
using RestSharpTemplate.Bases;
using RestSharpTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTemplate.Requests.PetStore
{
    public class AddPetRequest : RequestBase
    {

        public AddPetRequest()
        {
            url = "https://petstore.swagger.io/v2";
            requestService = "/pet";
            method = Method.POST;
        }

        public void setJsonBody()
        {
            jsonBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Jsons/AddPetRequest.json", Encoding.UTF8);
        }


    }
}
