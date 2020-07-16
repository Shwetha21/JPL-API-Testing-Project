using Newtonsoft.Json;
using System.Collections.Generic;

namespace CadApi.CadApiService.DataHandling
{
    public class APIDTO
    {
        public CADRoot CADData { get; set; }
        private List<CADKeyValues> cadList = new List<CADKeyValues>();

        public void DeserializeCADData(string CADResponse)
        {
            CADData = JsonConvert.DeserializeObject<CADRoot>(CADResponse);
        }

        public List<CADKeyValues> ConvertToList()
        {
            var valueArray = CADData.data;

            for (int i = 0; i < valueArray.Length; i++)
            {
                cadList.Add(
                    new CADKeyValues(
                        valueArray[i][0],
                        valueArray[i][1],
                        valueArray[i][2],
                        valueArray[i][3],
                        valueArray[i][4],
                        valueArray[i][5],
                        valueArray[i][6],
                        valueArray[i][7],
                        valueArray[i][8],
                        valueArray[i][9],
                        valueArray[i][10]
                    )
                );
            }

            return cadList;
        }
    }
}