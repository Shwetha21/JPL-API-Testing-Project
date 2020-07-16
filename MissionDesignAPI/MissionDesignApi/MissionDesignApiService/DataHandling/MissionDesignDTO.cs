using System.Collections.Generic;
using Newtonsoft.Json;

namespace MissionDesignApi.MissionDesignApiService.DataHandling
{
    public class MissionDesignDTO
    {
        public MissionDesignRoot MissionDesignData { get; set; }
        private List<MissionDesignKeyValues> missionDesignList = new List<MissionDesignKeyValues>();

        public void DeserializeMissionDesignData(string MissionDesignResponse)
        {
            MissionDesignData = JsonConvert.DeserializeObject<MissionDesignRoot>(MissionDesignResponse);
        }
        public List<MissionDesignKeyValues> ConvertToList()
        {
            var valueArray = MissionDesignData.selectedMissions;

            for (int i = 0; i < valueArray.Length; i++)
            {
                missionDesignList.Add(
                    new MissionDesignKeyValues(
                        valueArray[i][0],
                        valueArray[i][1],
                        valueArray[i][2],
                        valueArray[i][3],
                        valueArray[i][4],
                        valueArray[i][5],
                        valueArray[i][6],
                        valueArray[i][7],
                        valueArray[i][8],
                        valueArray[i][9]
                    )
                );
            }

            return missionDesignList;
        }
    }
}
