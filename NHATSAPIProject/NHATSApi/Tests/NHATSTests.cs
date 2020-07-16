using NHATSApi.NHATSApiService;
using NUnit.Framework;

namespace NHATSApi.Tests
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

        [Test]
        public void CheckingWhetherTheHValueOfAlltheObjectsAreGreaterThan15()
        {
            foreach (var i in nHATSAPIServices.nhatsDTO.NHATSData.data)
            {
                Assert.That(i.h, Is.GreaterThan("15"));
            }
        }

        [Test]
        public void CheckingWhetherTheOCCrangeIsInBetween0and10()
        {
            foreach (var i in nHATSAPIServices.nhatsDTO.NHATSData.data)
            {
                Assert.That(int.Parse(i.occ), Is.InRange(0, 10));
            }
        }
    }
}