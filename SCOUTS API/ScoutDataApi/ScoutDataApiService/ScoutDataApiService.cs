using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScoutDataApi.ScoutDataApiService.DataHandling;
using ScoutDataApi.ScoutDataApiService.HTTPManager;

namespace ScoutDataApi.ScoutDataApiService
{
    public class ScoutDataAPIService
    {
        public ScoutAPIManager ScoutDataManager = new ScoutAPIManager();
        public ScoutDTO ScoutDataDTO = new ScoutDTO();
        public string ScoutData;
        public JObject json_ScoutData;

        public ScoutDataAPIService()
        {
            ScoutData = ScoutDataManager.GetScoutData();
            ScoutDataDTO.DeserializeScoutData(ScoutData);
            json_ScoutData = JsonConvert.DeserializeObject<JObject>(ScoutData);
        }
    }
}