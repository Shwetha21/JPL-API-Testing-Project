using NUnit.Framework;
using SentryAPI.SentrydesDataApiService;

namespace SentryAPI.Tests
{
    public class SentryPsminTests
    {
        private SentryPsminDataAPIService _sentryDataApiService = new SentryPsminDataAPIService(-3);

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.PsminData.signature.version, Is.EqualTo("1.1"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.PsminData.signature.source, Is.EqualTo("NASA/JPL Sentry Data API"));
        }

        [Test]
        public void CallingAPI_CorrectCountResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.PsminData.count, Is.Not.Null.Or.Zero);
        }
    }
}