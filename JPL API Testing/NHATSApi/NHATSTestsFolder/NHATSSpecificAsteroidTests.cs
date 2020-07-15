using JPL_API_Testing.JPLAPIService;
using JPL_API_Testing.NHATSApi.NHATSApiService;
using NUnit.Framework;

namespace JPL_API_Testing.NHATSApi.NHATSTestsFolder
{
    public class NHATSSpecificAsteroidTests
    {
        private NHATSAPIServices nHATSAPIServices = new NHATSAPIServices("2000%20SG344");
        private NHATSAPIServices _nhatsServiceforOrpheus = new NHATSAPIServices("3361");

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
        public void CheckingWhetherHvalueIsGreatetThan15ToConsiderNEAASNHATS()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.h, Is.GreaterThan("15"));
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

        [Test]
        public void CheckingWhetherTheDataObtainedIsOfOrpheus()
        {
            Assert.That(_nhatsServiceforOrpheus.nhatsDTO.NHATSSpecificData.fullname.Trim(), Is.EqualTo("3361 Orpheus (1982 HR)"));
        }

        [Test]
        public void CheckingWhetherItsEstimatedMinimumSizeIs272()
        {
            Assert.That(_nhatsServiceforOrpheus.nhatsDTO.NHATSSpecificData.min_size, Is.EqualTo("272"));
        }

        [Test]
        public void CheckingWhetherEstimatedMaximumSizeIs1216()
        {
            Assert.That(_nhatsServiceforOrpheus.nhatsDTO.NHATSSpecificData.max_size, Is.EqualTo("1216"));
        }

        [Test]
        public void CheckingWhetherTotalDurationOfTheMissionIs362()
        {
            Assert.That(_nhatsServiceforOrpheus.nhatsDTO.NHATSSpecificData.min_dv_traj.dur_total, Is.EqualTo("362"));
        }

        [Test]
        public void CheckingWhetherHvalueofOrpheusIsGreatetThan15ToConsiderNEAASNHATS()
        {
            Assert.That(_nhatsServiceforOrpheus.nhatsDTO.NHATSSpecificData.h, Is.GreaterThan("15"));
        }

        [Test]
        public void ChechingForTheValueOfOCCIs0()
        {
            Assert.That(_nhatsServiceforOrpheus.nhatsDTO.NHATSSpecificData.occ, Is.EqualTo("0"));
        }

        [Test]
        public void CheckingForThelaunchDateOfOrpheus()
        {
            Assert.That(_nhatsServiceforOrpheus.nhatsDTO.NHATSSpecificData.min_dur_traj.launch, Is.EqualTo("2021-11-15"));
        }


    }
}
