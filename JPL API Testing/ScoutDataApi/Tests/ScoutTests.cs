using NUnit.Framework;
using System.Linq;
using JPL_API_Testing.ScoutDataApiService;

namespace JPL_API_Testing
{
    public class ScoutTests
    {
        ScoutDataAPIService _scoutDataApiService = new ScoutDataAPIService();

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_scoutDataApiService.ScoutDataDTO.ScoutData.signature.version, Is.EqualTo("1.2"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_scoutDataApiService.ScoutDataDTO.ScoutData.signature.source, Is.EqualTo("NASA/JPL Scout API"));
        }

        [Test]
        public void CallingAPI_CorrectCountResponse()
        {
            Assert.That(_scoutDataApiService.ScoutDataDTO.ScoutData.count, Is.EqualTo("22"));
        }


    }
}
