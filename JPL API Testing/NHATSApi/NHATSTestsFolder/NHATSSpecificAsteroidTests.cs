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
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.fullname.Trim(), Is.EqualTo("(2000 SG344)"));
        }

        [Test]
        public void CheckingWhetherItsEstimatedMinimumSizeIs20()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.min_size, Is.EqualTo("20"));
        }

        [Test]
        public void CheckingWhetherEstimatedMaximumSizeIs89()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.max_size, Is.EqualTo("89"));
        }

        [Test]
        public void CheckingWhetherTotalDurationOfTheMissionIs370()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.min_dv_traj.dur_total, Is.EqualTo("370"));
        }

        [Test]
        public void CheckingWhetherHvalueIsGreatetThan20ToConsiderNEAASNHATS()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.h, Is.GreaterThan("20"));
        }

        [Test]
        public void ChechingForTheValueOfOCC()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.occ, Is.EqualTo("3"));
        }

        [Test]
        public void CheckingForThelaunchDate()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.min_dur_traj.launch, Is.EqualTo("2028-04-08"));
        }
    

    }
}
