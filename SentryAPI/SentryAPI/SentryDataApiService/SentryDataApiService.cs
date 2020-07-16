using JPL_API_Testing.SentryAPI.SentrydesDataApiService.DataHandling;
using JPL_API_Testing.SentryAPI.SentrydesDataApiService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JPL_API_Testing.SentryAPI.SentrydesDataApiService
{
    public class SentryDataApiService
    {

        public SentryAPIManager SentryDataManager = new SentryAPIManager();
        public SentryDTO SentryDataDTO = new SentryDTO();
        public string SentryData;
        public JObject json_SentryData;

        public SentryDataApiService()
        {
            SentryData = SentryDataManager.GetSentryData();
            SentryDataDTO.DeserialiseSentryData(SentryData);
            json_SentryData = JsonConvert.DeserializeObject<JObject>(SentryData);
        }

        public SentryDataApiService(int spk)
        {
            SentryData = SentryDataManager.GetSentryData(spk);
            SentryDataDTO.DeserialiseSentryDataspk(SentryData);
            json_SentryData = JsonConvert.DeserializeObject<JObject>(SentryData);
        }


    }
}
