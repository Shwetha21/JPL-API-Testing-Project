using RestSharp;
using JPL_API_Library;


namespace NHATSAPIProject.NHATSApi.NHATSApiService.HTTPManager
    
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
            var request = new RestRequest();
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetDataOfSpecificNearEarthAsteroid(string asteroid)
        {
            var request = new RestRequest($"?des={asteroid}");
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
