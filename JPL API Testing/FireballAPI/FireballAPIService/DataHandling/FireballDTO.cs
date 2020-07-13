using Newtonsoft.Json;

namespace JPL_API_Testing.FireballAPI.FireballAPIService.DataHandling
{
    public class FireballDTO
    {
        public FireballModel FireballModel { get; set; }

        public void DeserialiseResponse(string res)
        {
            FireballModel = JsonConvert.DeserializeObject<FireballModel>(res);
        }
    }
}
