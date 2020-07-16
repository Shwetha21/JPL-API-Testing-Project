using NUnit.Framework;
using System.Linq;
using JPL_API_Testing.SentryAPI.SentrydesDataApiService;

namespace JPL_API_Testing.SentryAPI.Tests
{
    public class SentryPsminTests
    {
        SentryPsminDataAPIService _sentryDataApiService = new SentryPsminDataAPIService(-3);

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