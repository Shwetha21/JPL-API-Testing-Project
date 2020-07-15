using JPL_API_Testing.FireballAPI.FireballAPIService.DataHandling;
using JPL_API_Testing.FireballAPI.FireballAPIService.HTTPManager;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JPL_API_Testing.FireballAPI.FireballAPIService
{
    public class FBAPIService
    {
        public FireballAPIManager fireballAPIManager = new FireballAPIManager();
        public FireballDTO fireballDTO = new FireballDTO();        
        public List<FireballKeyValues> fireballData;
        public JObject json_fireball;
        public string fireballResponse;

        public FBAPIService()
        {
            fireballResponse = fireballAPIManager.GetFireball();
            fireballDTO.DeserialiseResponse(fireballResponse);

            fireballData = GetFireballData();
        }

        public FBAPIService(int limit)
        {
            fireballResponse = fireballAPIManager.GetFireball(limit);
            fireballDTO.DeserialiseResponse(fireballResponse);
        }

        public FBAPIService(int limit, string dateMin, string dateMax)
        {
            fireballResponse = fireballAPIManager.GetFireball(limit, dateMin, dateMax);
            fireballDTO.DeserialiseResponse(fireballResponse);

            fireballData = GetFireballData();
        }

        private List<FireballKeyValues> GetFireballData() => fireballDTO.ConvertToList();
    }
}