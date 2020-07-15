using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using NUnit.Framework;
using JPL_API_Testing.SbdbApiService;

namespace JPL_API_Testing
{
    public class SbdbTests
    {
        private SbdbService _sbdbDataResponse = new SbdbService("2015ab");

        [Test]
        public void CallingAPI_ResponseContainsSignatureField()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("signature"));
        }
        [Test]
        public void CallingAPI_ResponseContainsObjectField()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("_object"));
        }
        [Test]
        public void CallingApi_ResponseContainsOrbitField()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("orbit"));
        }
    }
}
