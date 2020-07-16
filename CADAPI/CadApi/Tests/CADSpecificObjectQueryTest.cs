using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPL_API_Testing.JPLAPIService;
using NUnit.Framework;

namespace CADAPI.CadApi.Tests
{
    class CADSpecificObjectQueryTest
    {
        private APIService _cadService = new APIService(3745588);
        
        [Test]
        public void CallingUniqueSPK_ReturnsOneResult()
        {
            Assert.That(_cadService.cadDataList.Count(), Is.EqualTo(1));
        }
        [Test]
        public void UniqueSPK_ReturnsCorrectDesignation()
        {
            Assert.That(_cadService.cadDataList.First().des, Is.EqualTo("2016 DY30"));
        }
        [Test]
        public void SPKNextClosestApproachDate_ReturnsFutureDate()
        {
            Assert.That(_cadService.cadDataList.First().cd.Substring(0, 11), Is.GreaterThan(DateTime.Now.ToString()));
        }
        [Test]
        public void SPKBrightness_IsAlwaysCorrect()
        {
            Assert.That(_cadService.cadDataList.First().h.ToString(), Is.EqualTo("30.5"));
        }
        [Test]
        public void CurrentDistance_LessThanMaxDistance()
        {
            Assert.That(_cadService.cadDataList.First().dist, Is.LessThan(_cadService.cadDataList.First().dist_max));
        }
        [Test]
        public void CurrentDistance_GreaterThanMinDistance()
        {
            Assert.That(_cadService.cadDataList.First().dist, Is.GreaterThan(_cadService.cadDataList.First().dist_min));
        }
        [TestCase(2000433)]
        [TestCase(3239432)]
        [TestCase(3213478)]
        [TestCase(2219879)]
        public void IncorrectSPK_ReturnsNoResults(int spk)
        {
            APIService _cadServiceIncorrect = new APIService(spk);
            Assert.That(_cadServiceIncorrect.json_cad["count"].ToString(), Is.EqualTo("0"));
        }
    }
}
