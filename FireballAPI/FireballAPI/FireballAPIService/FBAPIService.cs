using FireballAPI.FireballAPIService.DataHandling;
using FireballAPI.FireballAPIService.HTTPManager;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace FireballAPI.FireballAPIService
{
    public class FBAPIService
    {
        public FireballAPIManager fireballAPIManager = new FireballAPIManager();
        public FireballDTO fireballDTO = new FireballDTO();        
        public List<FireballKeyValues> fireballData;
        public JObject json_fireball;
        public string fireballResponse;

        public FBAPIService(string queryType, int recordLimit, string dateMin = "2019-11-28", string dateMax = "2019-11-29", string energyMin = "8.0", string energyMax = "10.0", string impacteMin = "3.0", string impacteMax = "10.0", int velMin = 20, int velMax = 50)
        {
            switch (queryType.ToLower())
            {
                case "all":
                    AllRequestService();
                    break;
                case "limit":
                    LimitQueryRequestService(recordLimit);
                    break;
                case "date":
                    DateQueryRequestService(dateMin, dateMax, recordLimit);
                    break;
                case "energy":
                    EnergyQueryRequestService(energyMin, energyMax, recordLimit);
                    break;
                case "impact-e":
                    ImpactEnergyQueryRequestService(impacteMin, impacteMax, recordLimit);
                    break;
                case "altitude":
                    VelocityQueryRequestService(velMin, velMax, recordLimit);
                    break;
            }
            
        }
        public void AllRequestService()
        {
            fireballResponse = fireballAPIManager.GetAllFireball();
            DataService();
        }

        public void LimitQueryRequestService(int recordLimit)
        {
            fireballResponse = fireballAPIManager.GetFireballLimit(recordLimit);
            DataService();
        }

        public void DateQueryRequestService(string dateMin, string dateMax, int recordLimit)
        {
            fireballResponse = fireballAPIManager.GetFireballDate(dateMin, dateMax, recordLimit);
            DataService();
        }

        public void EnergyQueryRequestService(string energyMin, string energyMax, int recordLimit)
        {
            fireballResponse = fireballAPIManager.GetFireballEnergy(energyMin, energyMax, recordLimit);
            DataService();
        }

        public void ImpactEnergyQueryRequestService(string impacteMin, string impacteMax, int recordLimit)
        {
            fireballResponse = fireballAPIManager.GetFireballImpactEnergy(impacteMin, impacteMax, recordLimit);
            DataService();
        }

        public void VelocityQueryRequestService(int velMin, int velMax, int recordLimit)
        {
            fireballResponse = fireballAPIManager.GetFireballVelocity(velMin, velMax, recordLimit);
            DataService();
        }

        public void DataService()
        {
            fireballDTO.DeserialiseResponse(fireballResponse);
            fireballData = GetFireballData();            
        }

        private List<FireballKeyValues> GetFireballData() => fireballDTO.ConvertToList();
    }
}