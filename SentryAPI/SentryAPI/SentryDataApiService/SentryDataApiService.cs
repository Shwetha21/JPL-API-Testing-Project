using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SentryAPI.SentrydesDataApiService.DataHandling;
using SentryAPI.SentrydesDataApiService.HTTPManager;

namespace SentryAPI.SentrydesDataApiService
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