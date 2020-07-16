using RestSharp;

namespace SbdbApi.SbdbApiService.HTTPManager
{
    public class SbdbApiManager
    {
        private readonly IRestClient client;

        public SbdbApiManager()
        {
            client = new RestClient(JPL_API_Library.ConfigReader.BaseUrl);
        }

        public string GetSmallBodyData(string asteroid)
        {
            var request = new RestRequest("sbdb.api?sstr=" + asteroid);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}