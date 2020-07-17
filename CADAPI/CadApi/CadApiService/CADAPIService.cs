using CadApi.CadApiService.DataHandling;
using CadApi.CadApiService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CadApi.CadApiService
{
    public class APIService
    {
        public APIManager cadManager = new APIManager();
        public APIDTO cadDTO = new APIDTO();
        public List<CADKeyValues> cadDataList;
        public string cadData;
        public JObject json_cad;

        public APIService()
        {
            cadData = cadManager.GetCloseApproachData();
            cadDTO.DeserializeCADData(cadData);
            json_cad = JsonConvert.DeserializeObject<JObject>(cadData);
            cadDataList = GetCADData();
        }

        public APIService(string distMin, string distMax)
        {
            cadData = cadManager.GetCloseApproachData(distMin, distMax);
            cadDTO.DeserializeCADData(cadData);
            json_cad = JsonConvert.DeserializeObject<JObject>(cadData);
            cadDataList = GetCADData();
        }

        public APIService(int spk)
        {
            cadData = cadManager.GetCloseApproachData(spk);
            cadDTO.DeserializeCADData(cadData);
            json_cad = JsonConvert.DeserializeObject<JObject>(cadData);
            if (cadDTO.CADData.count != "0") cadDataList = GetCADData();
        }

        public APIService(string type)
        {
            string call = "";
            switch (type)
            {
                case "pha":
                    call = "pha=true";
                    break;

                case "nea":
                    call = "nea=true";
                    break;

                case "comet":
                    call = "comet=true";
                    break;

                case "nea-comet":
                    call = "nea-comet=true";
                    break;

                case "neo":
                    call = "neo=true";
                    break;
            }
            cadData = cadManager.GetCloseApproachData(call);
            cadDTO.DeserializeCADData(cadData);
            json_cad = JsonConvert.DeserializeObject<JObject>(cadData);
            if (cadDTO.CADData.count != "0") cadDataList = GetCADData();
        }

        private List<CADKeyValues> GetCADData() => cadDTO.ConvertToList();
    }
}