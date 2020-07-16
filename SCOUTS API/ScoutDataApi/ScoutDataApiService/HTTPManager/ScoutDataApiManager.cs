using RestSharp;
using JPL_API_Library;

namespace JPL_API_Testing.ScoutDataApi.ScoutDataApiService.HTTPManager
{ 
    public class ScoutAPIManager
    {
        private readonly IRestClient client;

        public ScoutAPIManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }

        public string GetScoutData()
        {
            var request = new RestRequest();
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
