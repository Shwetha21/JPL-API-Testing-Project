

using Newtonsoft.Json;

namespace JPL_API_Testing.NHATSApi.NHATSApiService.DataHandling
{
    public class NHATSDTO
    {
        public NHATSRoot NHATSData { get; set; }

        public NHATSSpecificRoot NHATSSpecificData { get; set; }

        public void DeserializeNHATSData(string NHATSResponse)
        {
            NHATSData = JsonConvert.DeserializeObject<NHATSRoot>(NHATSResponse);
        }

        public void DesirealiseNHATSSpecificData(string NHATSSpecificResponse)
        {
            NHATSSpecificData = JsonConvert.DeserializeObject<NHATSSpecificRoot>(NHATSSpecificResponse);
        }
    }
}
