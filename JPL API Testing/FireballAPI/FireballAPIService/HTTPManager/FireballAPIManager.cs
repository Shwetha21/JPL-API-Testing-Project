using RestSharp;

namespace JPL_API_Testing.FireballAPI.FireballAPIService.HTTPManager
{
    public class FireballAPIManager
    {
        private readonly IRestClient client;

        public FireballAPIManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }

        public string GetFireball()
        {
            var request = new RestRequest("fireball.api", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
