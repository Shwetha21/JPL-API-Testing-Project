using JPL_API_Library;
using RestSharp;

namespace NHATSApi.NHATSApiService.HTTPManager

{
    public class NHATSAPIManager
    {
        private readonly IRestClient client;

        public NHATSAPIManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }

        public string GetNearEarthOrbitData()
        {
            var request = new RestRequest("nhats.api");
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetDataOfSpecificNearEarthAsteroid(string asteroid)
        {
            var request = new RestRequest($"nhats.api?des={asteroid}");
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetNearEarthOrbitData(string asteroid, string velocity, string duration, string stay, string launch)
        {
            var request = new RestRequest($"nhats.api?des={asteroid}&dv={velocity}&dur={duration}&stay={stay}&launch={launch}");
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}