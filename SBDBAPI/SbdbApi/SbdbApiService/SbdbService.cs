using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SbdbApi.SbdbApiService.DataHandling;
using SbdbApi.SbdbApiService.HTTPManager;

namespace SbdbApi.SbdbApiService
{
    public class SbdbService
    {
        public SbdbApiManager sbdbManager = new SbdbApiManager();
        public SbdbDTO sbdbDTO = new SbdbDTO();
        public string sbdbData;
        public JObject json_sbdb;

        public SbdbService(string asteroid)
        {
            sbdbData = sbdbManager.GetSmallBodyData(asteroid);
            sbdbDTO.DeserializeSbdbData(sbdbData);
            json_sbdb = JsonConvert.DeserializeObject<JObject>(sbdbData);
        }
    }
}