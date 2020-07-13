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
    }
}
