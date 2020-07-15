using RestSharp;

namespace JPL_API_Testing.SentryAPI.SentryDataApiService.HTTPManager
{
    public class SentryAPIManager
    {
        private readonly IRestClient client;

        public SentryAPIManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }

        public string GetSentryData()
        {
            var request = new RestRequest("sentry.api", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetSentryData(int spk)
        {
            var request = new RestRequest($"sentry.api?spk={spk}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}