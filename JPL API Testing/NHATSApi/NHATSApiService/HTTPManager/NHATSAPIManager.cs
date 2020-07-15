using RestSharp;

namespace JPL_API_Testing.JPLAPIService.HTTPManager
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
    }
}
