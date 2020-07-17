using Newtonsoft.Json;

namespace ScoutDataApi.ScoutDataApiService.DataHandling
{
    public class ScoutDTO
    {
        public ScoutRoot ScoutData { get; set; }

        public void DeserializeScoutData(string ScoutResponse)
        {
            ScoutData = JsonConvert.DeserializeObject<ScoutRoot>(ScoutResponse);
        }
    }
}