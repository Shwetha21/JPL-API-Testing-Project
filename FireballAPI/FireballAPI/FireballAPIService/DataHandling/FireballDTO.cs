using Newtonsoft.Json;
using System.Collections.Generic;

namespace FireballAPI.FireballAPIService.DataHandling
{
    public class FireballDTO
    {
        public FireballModel FireballModel { get; set; }
        private List<FireballKeyValues> fireballList = new List<FireballKeyValues>();

        public void DeserialiseResponse(string res)
        {
            FireballModel = JsonConvert.DeserializeObject<FireballModel>(res);
        }

        public List<FireballKeyValues> ConvertToList()
        {
            var valueArray = FireballModel.data;

            for (int i = 0; i < valueArray.Length; i++)
            {
                fireballList.Add(
                    new FireballKeyValues(
                        valueArray[i][0],
                        valueArray[i][1],
                        valueArray[i][2],
                        valueArray[i][3],
                        valueArray[i][4],
                        valueArray[i][5],
                        valueArray[i][6],
                        valueArray[i][7],
                        valueArray[i][8]
                    )
                );
            }

            return fireballList;
        }
    }
}