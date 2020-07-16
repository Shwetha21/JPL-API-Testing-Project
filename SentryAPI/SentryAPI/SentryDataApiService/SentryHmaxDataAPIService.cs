using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SentryAPI.SentrydesDataApiService.DataHandling;
using SentryAPI.SentrydesDataApiService.HTTPManager;

namespace SentryAPI.SentrydesDataApiService
{
    public class SentryHmaxDataAPIService
    {
        public SentryAPIManager SentryDataManager = new SentryAPIManager();
        public SentryDTO SentryDataDTO = new SentryDTO();
        public string SentryData;
        public JObject json_SentryData;

        public SentryHmaxDataAPIService(int hMax)
        {
            SentryData = SentryDataManager.GetSentryHmaxData(hMax);
            SentryDataDTO.DeserialiseSentryDataHmax(SentryData);
            json_SentryData = JsonConvert.DeserializeObject<JObject>(SentryData);
        }
    }
}