using JPL_API_Testing.JPLAPIService;
using JPL_API_Testing.NHATSApi.NHATSApiService;
using NUnit.Framework;

namespace JPL_API_Testing.NHATSApi.NHATSTestsFolder
{
    public class NHATSSpecificAsteroidTests
    {
        private NHATSAPIServices nHATSAPIServices = new NHATSAPIServices("2000%20SG344");

        [Test]
        public void CheckingWhetherTheDataObtainedIsOf2000SG344Asteroid()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.fullname, Is.EqualTo("2000 SG344"));
        }

    }
}
