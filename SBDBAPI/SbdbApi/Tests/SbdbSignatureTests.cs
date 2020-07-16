using NUnit.Framework;
using SbdbApi.SbdbApiService;

namespace JPL_API_Testing.SbdbApi.Tests
{
    internal class SbdbSignatureTests
    {
        private SbdbService _sbdbDataResponse = new SbdbService("2015ab");

        [Test]
        public void CallingAPI_CorrectSignatureResponse()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature, Has.Property("version"));
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature, Has.Property("source"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature.source, Is.EqualTo("NASA/JPL Small-Body Database (SBDB) API"));
        }

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature.version.Substring(0, 3), Is.EqualTo("1.2"));
        }
    }
}