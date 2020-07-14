
using JPL_API_Testing.JPLAPIService;
using NUnit.Framework;
using System.Linq;

namespace JPL_API_Testing.NHATSApi.NHATSTestsFolder
{
    public class NHATSTests
    {
        private NHATSAPIServices nHATSAPIServices = new NHATSAPIServices();

        [Test]
        public void CheckingWheateherTheSourceIsNhatsDataApi()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.signature.source.Contains("NHATS Data API"), Is.True);
        }

        [Test]
        public void CheckingWhetherNereusIsOneofTheNearEarthObject()
        {
            var res = nHATSAPIServices.nhatsDTO.NHATSData.data[0].fullname;
            Assert.That(res.Contains("Nereus"), Is.True);
        }

        [Test]
        public void CheckingWhetherTheDataObtainedIsRecentByCheckingTheVersiion()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.signature.version, Is.EqualTo("1.3"));
        }

        [Test]
        public void CheckingWhetherTheCountvalueIsNotNull()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.count, Is.Not.Null);
        }
    }
}
