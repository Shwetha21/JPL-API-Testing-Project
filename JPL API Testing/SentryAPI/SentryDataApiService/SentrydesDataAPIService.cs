using JPL_API_Testing.SentryAPI.SentrydesDataApiService.DataHandling;
using JPL_API_Testing.SentryAPI.SentrydesDataApiService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JPL_API_Testing.SentryAPI.SentrydesDataApiService
{
    public class SentrydesDataAPIService
    {
        public SentryAPIManager SentryDataManager = new SentryAPIManager();
        public SentryDTO SentryDataDTO = new SentryDTO();
        public string SentryData;
        public JObject json_SentryData;


        public SentrydesDataAPIService(int des)
        {
            SentryData = SentryDataManager.GetSentrydesData(des);
            SentryDataDTO.DeserialiseSentryDatades(SentryData);
            json_SentryData = JsonConvert.DeserializeObject<JObject>(SentryData);
        }
    }
}
