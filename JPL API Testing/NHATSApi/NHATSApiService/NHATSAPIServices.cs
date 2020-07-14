using JPL_API_Testing.JPLAPIService.DataHandling;
using JPL_API_Testing.JPLAPIService.HTTPManager;
using JPL_API_Testing.NHATSApi.NHATSApiService.DataHandling;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JPL_API_Testing.JPLAPIService
{
    public class NHATSAPIServices
    {
        public NHATSAPIManager cadManager = new NHATSAPIManager();
        public NHATSDTO nhatsDTO = new NHATSDTO();
        public string nhatsData;
        public JObject json_nhats;

        public NHATSAPIServices()
        {
            nhatsData = cadManager.GetNearEarthOrbitData();
            nhatsDTO.DeserializeNHATSData(nhatsData);

            json_nhats = JsonConvert.DeserializeObject<JObject>(nhatsData);
        }

        public NHATSAPIServices(string asteroid)
        {
            nhatsData = cadManager.GetDataOfSpecificNearEarthAsteroid(asteroid);
            nhatsDTO.DeserializeNHATSData(nhatsData);

            json_nhats = JsonConvert.DeserializeObject<JObject>(nhatsData);
        }
    }
}
