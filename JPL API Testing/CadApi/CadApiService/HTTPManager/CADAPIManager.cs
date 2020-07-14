using RestSharp;

namespace JPL_API_Testing.JPLAPIService.HTTPManager
{
    public class APIManager
    {
        private readonly IRestClient client;

        public APIManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }
        public string GetCloseApproachData()
        {
            var request = new RestRequest("cad.api");
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
