using NUnit.Framework;
using ScoutDataApi.ScoutDataApiService;

namespace JPL_API_Testing
{
    public class ScoutTests
    {
        private ScoutDataAPIService _scoutDataApiService = new ScoutDataAPIService();

        [Test]
        public void CallingAPI_ResponseContainsAllRequiredFields()
        {
            Assert.That(_scoutDataApiService.ScoutDataDTO.ScoutData, Has.Property("signature"));
            Assert.That(_scoutDataApiService.ScoutDataDTO.ScoutData, Has.Property("data"));
            Assert.That(_scoutDataApiService.ScoutDataDTO.ScoutData, Has.Property("count"));
        }

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
            Assert.That(_scoutDataApiService.ScoutDataDTO.ScoutData.count, Is.Not.Null);
        }
    }
}