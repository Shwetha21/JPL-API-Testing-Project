using NHATSApi.NHATSApiService;
using NUnit.Framework;

namespace NHATSApi.Tests
{
    public class NHATSTests
    {
        private NHATSAPIServices nHATSAPIServices = new NHATSAPIServices();
        private NHATSAPIServices _nhatsApiservice = new NHATSAPIServices("2020-2025","8");
        private NHATSAPIServices _nhatsApiservice30 = new NHATSAPIServices("2025-2030","8");
        private NHATSAPIServices nHATSAPIServices35 = new NHATSAPIServices("2030-2035", "8");

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

        [Test]
        public void CheckingforapropertyCount()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData, Has.Property("count"));
        }

        [Test]
        public void CheckingforpropertyVersion()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.signature, Has.Property("version"));
        }

        [Test]
        public void CheckingForPropertySource()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.signature, Has.Property("source"));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void CheckingIfOrbitIdIsNotNull(int index)
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.data[index].orbit_id, Is.Not.Null);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void CheckingIfMinSizeOfsampleasteridsisnotNull(int index)
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.data[index].min_size, Is.Not.Null);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void CheckingFormaxSixeisNotnull(int index)
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.data[index].max_size, Is.Not.Null);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void CheckingForDurationOfMissionisnotNull(int index)
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.data[index].min_dur, Is.Not.Null);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void CheckingForvelocityNotNull(int index)
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.data[index].min_dv, Is.Not.Null);
        }

        [Test]
        public void CheckingForLauncWindow2025()
        {
            Assert.That(_nhatsApiservice.nhatsDTO.NHATSData.count, Is.Not.Null);
        }

        [Test]
        public void CheckingForLauncWindow2030()
        {
            Assert.That(_nhatsApiservice30.nhatsDTO.NHATSData.count, Is.Not.Null);
        }

        [Test]
        public void CheckingForLauncWindow2035()
        {
            Assert.That(nHATSAPIServices35.nhatsDTO.NHATSData.count, Is.Not.Null);
        }

    }
}