using JPL_API_Testing.SbdbApiService.DataHandling;
using JPL_API_Testing.SbdbApiService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JPL_API_Testing.SbdbApiService
{
    public class SbdbService
    {
        public SbdbApiManager sbdbManager = new SbdbApiManager();
        public SbdbDTO sbdbDTO = new SbdbDTO();
        public string sbdbData;
        public JObject json_sbdb;

        public SbdbService()
        {
            sbdbData = sbdbManager.GetSmallBodyData();
            sbdbDTO.DeserializeSbdbData(sbdbData);
            json_sbdb = JsonConvert.DeserializeObject<JObject>(sbdbData);
        }
    }
}
