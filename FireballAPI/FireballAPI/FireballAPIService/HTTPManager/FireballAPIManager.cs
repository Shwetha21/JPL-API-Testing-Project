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

        public string GetFireball()
        {
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetFireball(int recLimit)
        {
            var request = new RestRequest($"?limit={recLimit}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetFireball(string dateMin, string dateMax)
        {
            var request = new RestRequest($"?date-min={dateMin}&date-max={dateMax}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}