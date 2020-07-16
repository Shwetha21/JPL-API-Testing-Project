using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using JPL_API_Testing.JPLAPIService;
using NUnit.Framework;

namespace CADAPI.CadApi.Tests
{
    class CADDistanceLimitQueryTests
    {
        private static string _distMin = "0.01";
        private static string _distMax = "0.05";
        private APIService _cadServiceDistance = new APIService(_distMin, _distMax);
        
        [Test]
        public void CallingAPI_ReturnsSomeResults()
        {
            Assert.That(_cadServiceDistance.cadDataList.Count(), Is.Not.Zero);
        }
        [Test]
        public void ObejectDistanceReturned_LessThanMaxDistance()
        {
            int numOfResponse = _cadServiceDistance.cadDataList.Count();
            for(int i=0; i < numOfResponse; i++)
            {
                Assert.That(_cadServiceDistance.cadDataList[i].dist, Is.LessThan(_distMax));
            }
        }
        [Test]
        public void ObejectDistanceReturned_MoreThanMinDistance()
        {
            int numOfResponse = _cadServiceDistance.cadDataList.Count();
            for (int i = 0; i < numOfResponse; i++)
            {
                Assert.That(_cadServiceDistance.cadDataList[i].dist, Is.GreaterThan(_distMin));
            }
        }
        [Test]
        public void SmallerDistMin_IncreasesNumberOfresponses()
        {
             APIService _cadServiceSmallerDistance = new APIService("0.001", _distMax);
            Assert.That(_cadServiceDistance.cadDataList.Count(), Is.LessThan(_cadServiceSmallerDistance.cadDataList.Count()));
        }
    }
}
