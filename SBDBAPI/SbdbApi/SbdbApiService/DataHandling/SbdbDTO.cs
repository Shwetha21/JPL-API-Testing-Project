using Newtonsoft.Json;

namespace SbdbApi.SbdbApiService.DataHandling
{
    public class SbdbDTO
    {
        public SbdbRoot SbdbData { get; set; }

        public void DeserializeSbdbData(string SbdbResponse)
        {
            SbdbData = JsonConvert.DeserializeObject<SbdbRoot>(SbdbResponse);
        }
    }
}