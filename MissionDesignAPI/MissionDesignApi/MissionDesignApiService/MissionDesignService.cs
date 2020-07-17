using MissionDesignApi.MissionDesignApiService.DataHandling;
using MissionDesignApi.MissionDesignApiService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MissionDesignApi.MissionDesignApiService
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