using Newtonsoft.Json;

namespace JPL_API_Testing.MissionDesignApiService.DataHandling
{
    public class MissionDesignDTO
    {
        public MissionDesignRoot MissionDesignData { get; set; }
        
        public void DeserializeMissionDesignData(string MissionDesignResponse)
        {
            MissionDesignData = JsonConvert.DeserializeObject<MissionDesignRoot>(MissionDesignResponse);
        }
    }
}
