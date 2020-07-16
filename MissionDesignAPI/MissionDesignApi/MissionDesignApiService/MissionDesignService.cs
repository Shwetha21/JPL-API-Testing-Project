using System.Collections.Generic;
using JPL_API_Testing.MissionDesignApi.MissionDesignApiService.DataHandling;
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
        public List<MissionDesignKeyValues> missionDesignDataList;
        public string MissionDesignData;
        public JObject json_MissionDesign;

        public MissionDesignService(string desiredObject)
        {
            MissionDesignData = MissionDesignManager.GetMissionDesignData(desiredObject);
            MissionDesignDTO.DeserializeMissionDesignData(MissionDesignData);
            json_MissionDesign = JsonConvert.DeserializeObject<JObject>(MissionDesignData);
            missionDesignDataList = GetMissionDesignData();
        }
        private List<MissionDesignKeyValues> GetMissionDesignData() => MissionDesignDTO.ConvertToList();
    }
}
