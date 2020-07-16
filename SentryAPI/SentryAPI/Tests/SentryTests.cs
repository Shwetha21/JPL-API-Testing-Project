using NUnit.Framework;
using SentryAPI.SentrydesDataApiService;

namespace SentryAPI.Tests
{
    public class SentryTests
    {
        private SentryDataApiService _sentryDataApiService = new SentryDataApiService();

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.SentryData.signature.version, Is.EqualTo("1.1"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.SentryData.signature.source, Is.EqualTo("NASA/JPL Sentry Data API"));
        }

        [Test]
        public void CallingAPI_CorrectCountResponse()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.SentryData.count, Is.Not.Null.Or.Zero);
        }
    }
}