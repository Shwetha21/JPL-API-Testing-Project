using Newtonsoft.Json;


namespace JPL_API_Testing.SentryAPI.SentryDataApiService.DataHandling
{
    public class SentryDTO
    {

        public SentryRoot SentryData { get; set; }

        public void DeserialiseSentryData(string SentryResponse)
        {
            SentryData = JsonConvert.DeserializeObject<SentryRoot>(SentryResponse);
        }
    }
}
