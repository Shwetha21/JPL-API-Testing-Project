using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHATSApi.NHATSApiService.DataHandling;
using NHATSApi.NHATSApiService.HTTPManager;

namespace NHATSApi.NHATSApiService
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
            nhatsDTO.DesirealiseNHATSSpecificData(nhatsData);

            json_nhats = JsonConvert.DeserializeObject<JObject>(nhatsData);
        }

        public NHATSAPIServices(string asteroid, string velocity, string duration, string stay, string launch)
        {
            nhatsData = cadManager.GetNearEarthOrbitData(asteroid, velocity, duration, stay, launch);
            nhatsDTO.DesirealiseNHATSSpecificData(nhatsData);

            json_nhats = JsonConvert.DeserializeObject<JObject>(nhatsData);
        }

        public NHATSAPIServices(string launch, string stay)
        {
            
            nhatsData = cadManager.GetNearEarthOrbitData(launch,stay);
            nhatsDTO.DeserializeNHATSData(nhatsData);

            json_nhats = JsonConvert.DeserializeObject<JObject>(nhatsData);
        }
    }
}