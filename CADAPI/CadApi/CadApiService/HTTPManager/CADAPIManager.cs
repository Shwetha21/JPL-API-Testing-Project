using JPL_API_Library;
using RestSharp;

namespace CadApi.CadApiService.HTTPManager
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

        public string GetCloseApproachData(string distMin, string distMax)
        {
            var request = new RestRequest("cad.api?dist-min=" + distMin + "&dist-max=" + distMax);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetCloseApproachData(int spk)
        {
            var request = new RestRequest("cad.api?spk=" + spk);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetCloseApproachData(string type)
        {
            var request = new RestRequest("cad.api?" + type);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}