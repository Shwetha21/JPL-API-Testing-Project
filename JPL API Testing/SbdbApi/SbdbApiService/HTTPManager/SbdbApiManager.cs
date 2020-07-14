using RestSharp;

namespace JPL_API_Testing.SbdbApiService.HTTPManager
{
    public class SbdbApiManager
    {
        private readonly IRestClient client;

        public SbdbApiManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }
        public string GetSmallBodyData()
        {
            var request = new RestRequest("sbdb.api?sstr=2015ab");
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
