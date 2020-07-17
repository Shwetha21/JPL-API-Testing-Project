using JPL_API_Library;
using RestSharp;

namespace FireballAPI.FireballAPIService.HTTPManager
{
    public class FireballAPIManager
    {
        private readonly IRestClient client;

        public FireballAPIManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }

        public string GetAllFireball()
        {
            var request = new RestRequest("fireball.api", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetFireballLimit(int recordLimit)
        {
            var request = new RestRequest($"fireball.api?limit={recordLimit}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetFireballDate(string dateMin, string dateMax, int recordLimit)
        {
            var request = new RestRequest($"fireball.api?date-min={dateMin}&date-max={dateMax}&limit={recordLimit}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetFireballEnergy(string energyMin, string energyMax, int recordLimit)
        {
            var request = new RestRequest($"fireball.api?energy-min={energyMin}&energy-max={energyMax}&limit={recordLimit}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetFireballImpactEnergy(string impacteMin, string impacteMax, int recordLimit)
        {
            var request = new RestRequest($"fireball.api?impact-e-min={impacteMin}&impact-e-max={impacteMax}&limit={recordLimit}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetFireballVelocity(int velMin, int velMax, int recordLimit)
        {
            var request = new RestRequest($"fireball.api?vel-min={velMin}&vel-max={velMax}&limit={recordLimit}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}