using NUnit.Framework;
using SbdbApi.SbdbApiService;

namespace SbdbApi.Tests
{
    public class SbdbTests
    {
        private SbdbService _sbdbDataResponse = new SbdbService("2015ab");

        [Test]
        public void CallingAPI_ResponseContainsSignatureField()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("signature"));
        }

        [Test]
        public void CallingAPI_ResponseContainsObjectField()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("_object"));
        }

        [Test]
        public void CallingApi_ResponseContainsOrbitField()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("orbit"));
        }
    }
}