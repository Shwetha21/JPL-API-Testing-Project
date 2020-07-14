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
        private SbdbService _sbdbDataResponse = new SbdbService();

        [Test]
        public void CallingAPI_ResponseContainsAllRequiredFields()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("signature"));
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("_object"));
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData, Has.Property("orbit"));
        }

        [Test]
        public void CallingAPI_CorrectSignatureResponse()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature, Has.Property("version"));
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature, Has.Property("source"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature.source, Is.EqualTo("NASA/JPL Small-Body Database (SBDB) API"));
        }

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature.version.Substring(0,3), Is.EqualTo("1.2"));
        }
    }
}
