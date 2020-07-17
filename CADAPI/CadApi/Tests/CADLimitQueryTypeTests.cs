using CadApi.CadApiService;
using NUnit.Framework;

namespace CadApiService.Tests
{
    internal class CADLimitQueryTypeTests
    {
        private APIService _cadServicePHA = new APIService("pha");
        private APIService _cadServiceNEA = new APIService("nea");
        private APIService _cadServiceComet = new APIService("comet");
        private APIService _cadServiceNEAComet = new APIService("nea-comet");
        private APIService _cadServiceNEO = new APIService("neo");

        [Test]
        public void CallingForPHAType_ReturnsCorrectValues()
        {
            Assert.That(_cadServicePHA.cadDTO.CADData.count, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void CallingForNEAType_ReturnsCorrectValues()
        {
            Assert.That(_cadServiceNEA.cadDTO.CADData.count, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void CallingForCometType_ReturnsZeroResults()
        {
            Assert.That(_cadServiceComet.json_cad["count"].ToString(), Is.EqualTo("0"));
        }

        [Test]
        public void CallingForNEACometType_ReturnsCountEqualToSumOFCounts()
        {
            Assert.That(_cadServiceNEAComet.cadDataList.Count, Is.EqualTo(_cadServiceNEA.cadDataList.Count));
        }

        [Test]
        public void CallingForNEOType_ReturnsCountOfAllCloseObjects()
        {
            Assert.That(_cadServiceNEAComet.cadDataList.Count, Is.EqualTo(_cadServiceNEO.cadDataList.Count));
        }
    }
}