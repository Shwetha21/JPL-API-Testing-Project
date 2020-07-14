using JPL_API_Testing.FireballApi.FireballAPIService.DataHandling;
using JPL_API_Testing.FireballAPI.FireballAPIService.DataHandling;
using JPL_API_Testing.FireballAPI.FireballAPIService.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JPL_API_Testing.FireballAPI.FireballAPIService
{
    public class FBAPIService
    {
        public FireballAPIManager fireballAPIManager = new FireballAPIManager();
        public FireballDTO fireballDTO = new FireballDTO();
        public FireballModel fireballModel;
        public string fireballResponse;
        public List<FireballKeyValues> fireballData;
        public JObject json_fireball;

        public FBAPIService()
        {
            fireballResponse = fireballAPIManager.GetFireball();
            fireballDTO.DeserialiseResponse(fireballResponse);
            json_fireball = JsonConvert.DeserializeObject<JObject>(fireballResponse);

            fireballData = GetFireballData();
        }

        private List<FireballKeyValues> GetFireballData() => fireballDTO.ConvertToList();
    }
}
