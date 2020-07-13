

using Newtonsoft.Json;

namespace JPL_API_Testing.NHATSApi.NHATSApiService.DataHandling
{
    public class NHATSDTO
    {
        public NHATSRoot NHATSData { get; set; }

        public void DeserializeNHATSData(string CADResponse)
        {
            NHATSData = JsonConvert.DeserializeObject<NHATSRoot>(CADResponse);
        }
    }
}
