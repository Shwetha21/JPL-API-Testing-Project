
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

        [Test]
        public void CheckingWhetherTheHValueOfAlltheObjectsAreGreaterThan15()
        {
            foreach( var i in nHATSAPIServices.nhatsDTO.NHATSData.data)
            { 
                Assert.That(i.h, Is.GreaterThan("15")); 
            }
            
        }

        [Test]
        public void CheckingWhetherTheOCCrangeIsInBetween0and10()
        {
            foreach( var i in nHATSAPIServices.nhatsDTO.NHATSData.data)
            {
                Assert.That(int.Parse(i.occ), Is.InRange(0,10));
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
    }
}
