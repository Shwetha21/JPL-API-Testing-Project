using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SentryAPI.SentrydesDataApiService.DataHandling;
using SentryAPI.SentrydesDataApiService.HTTPManager;

namespace SentryAPI.SentrydesDataApiService
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