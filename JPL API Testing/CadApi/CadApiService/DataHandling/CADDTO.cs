using Newtonsoft.Json;

namespace JPL_API_Testing.JPLAPIService.DataHandling
{
    public class APIDTO
    {
        public CADRoot CADData { get; set; }
        
        public void DeserializeCADData(string CADResponse)
        {
            CADData = JsonConvert.DeserializeObject<CADRoot>(CADResponse);
        }
    }
}
