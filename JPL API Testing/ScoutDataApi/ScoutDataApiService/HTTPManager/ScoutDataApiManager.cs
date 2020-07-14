using RestSharp;

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
            var request = new RestRequest("scout.api", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
