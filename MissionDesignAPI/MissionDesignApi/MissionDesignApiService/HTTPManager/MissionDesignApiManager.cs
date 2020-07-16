using RestSharp;

namespace JPL_API_Testing.MissionDesignApiService.HTTPManager
{
    public class MissionDesignApiManager
    {
        private readonly IRestClient client;

        public MissionDesignApiManager()
        {
            client = new RestClient(JPL_API_Library.ConfigReader.BaseUrl);
        }
        public string GetMissionDesignData(string desiredObject)
        {
            var request = new RestRequest("mdesign.api?sstr=" + desiredObject);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
