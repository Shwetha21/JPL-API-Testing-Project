using JPL_API_Testing.ScoutDataApi.ScoutDataApiService.DataHandling;
using JPL_API_Testing.ScoutDataApi.ScoutDataApiService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JPL_API_Testing.ScoutDataApiService
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
