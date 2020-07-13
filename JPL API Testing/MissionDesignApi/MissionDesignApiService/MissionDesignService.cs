using JPL_API_Testing.MissionDesignApiService.DataHandling;
using JPL_API_Testing.MissionDesignApiService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JPL_API_Testing.MissionDesignApiService
{
    public class MissionDesignService
    {
        public MissionDesignApiManager MissionDesignManager = new MissionDesignApiManager();
        public MissionDesignDTO MissionDesignDTO = new MissionDesignDTO();
        public string MissionDesignData;
        public JObject json_MissionDesign;

        public MissionDesignService()
        {
            MissionDesignData = MissionDesignManager.GetMissionDesignData();
            MissionDesignDTO.DeserializeMissionDesignData(MissionDesignData);
            json_MissionDesign = JsonConvert.DeserializeObject<JObject>(MissionDesignData);
        }
    }
}
