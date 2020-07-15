using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JPL_API_Testing.SbdbApiService;

namespace JPL_API_Testing.SbdbApi.Tests
{
    class SbdbObjectTests
    {
        private SbdbService _sbdbDataResponse = new SbdbService();
        //[Test]
        //public void CallingAPI_CorrectSignatureResponse()
        //{
        //    Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature, Has.Property("version"));
        //    Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.signature, Has.Property("source"));
        //}
        [Test]
        public void ObjectFieldContainsNEOStatement()           //NEO - Near Earth Object
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("neo"));
        }
        [Test]
        public void ObjectFieldContainsPHAStatement()           //PHA - Potentially Hazardous Asteroid
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("pha"));
        }
        [Test]
        public void ObjectFieldContainSpkIDTag()                //SPK ID - ID code to identify a body and its centre of motion
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("spk"));
        }
        [Test]
        public void ObjectFieldContainsCategorisationCode()     //Kind - Whether the asteroid or comet is numbered (an/cn) or not (au/cu) 
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("kind"));
        }
        [Test]
        public void ObjectFieldContainsOrbitIdentifier()        //A unique code to identify the orbit solution
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("orbit_id"));
        }
        [Test]
        public void ObjectFieldContainsFullObjectName()
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("fullname"));
        }
        [Test]
        public void ObjectFieldContainsDesignationCode()        //Naming convention giving the date of discovery.
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("des"));
        }
        [Test]
        public void ObjectFieldContainsPrefixForDesignation()   //Null for asteroids, designate the time of the year.
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("prefix"));
        }
        [Test]
        public void ObjectFieldContainsOrbitClass()
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"].ToString(), Does.Contain("orbit_class"));
        }
        [Test]
        public void ObjectOrbit_ClassHasNameField()
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["orbit_class"].ToString(), Does.Contain("name"));
        }
        [Test]
        public void ObjectOrbit_ClassHasCode()
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["orbit_class"].ToString(), Does.Contain("code"));
        }
    }
}
