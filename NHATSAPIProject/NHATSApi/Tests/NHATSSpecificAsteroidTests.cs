using NHATSApi.NHATSApiService;
using NUnit.Framework;
using System;

namespace NHATSApi.Tests
{
    public class NHATSSpecificAsteroidTests
    {
        private NHATSAPIServices nHATSAPIServices = new NHATSAPIServices("2000%20SG344");
        private NHATSAPIServices _nhatsServiceforOrpheus = new NHATSAPIServices("3361");
        private NHATSAPIServices _nhatsservivenullasteroid = new NHATSAPIServices("");
        private NHATSAPIServices _invalidnhats = new NHATSAPIServices("134");
        private NHATSAPIServices _nHATSAPIServices = new NHATSAPIServices("2016%20TB18");

        
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

        //occ value determine how well the orbit is defined value range from 0-8
        [Test]
        public void ChechingForTheValueOfOCC()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSSpecificData.occ, Is.EqualTo("3"));
        }

       //launch Window - time duration suitable for launching the space mission to study the asteroid. 
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

        // h is a magnitude value of a lminosity
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

        // status- 400 for bad response
        [Test]
        public void CheckingForBadRequestresponseWhentheDesValueIsNull()
        {
            Assert.That(_nhatsservivenullasteroid.nhatsData, Does.Contain("400"));
        }

        // Checking for the error message for bad request
        [Test]
        public void CheckingFortheMessageForBadResponse()
        {
            Assert.That(_nhatsservivenullasteroid.nhatsData, Does.Contain("invalid character in designation"));
        }

        [Test]
        public void CheckingForErrorMessage()
        {
            Assert.That(_invalidnhats.nhatsData, Does.Contain("specified NHATS object not found"));
        }

        //checking for Degree of arrival
        [Test]
        public void CheckingForAnglrofArrival()
        { 
            Assert.That(_nHATSAPIServices.nhatsDTO.NHATSSpecificData.min_dv_traj.dec_arr, Is.Not.Null); ;
        }

        //Checking for degree of departure
        [Test]
        public void CheckingforAngleofDeparture()
        {
            Assert.That(_nHATSAPIServices.nhatsDTO.NHATSSpecificData.min_dv_traj.dec_dep, Is.Not.Null);
        }

        //dur_at - Duration at which the space mission stays with the asteroid
        [Test]
        public void CheckingforPropertyDurationAt()
        {
            Assert.That(_nHATSAPIServices.nhatsDTO.NHATSSpecificData.min_dv_traj.dur_at, Is.Not.Null);
        }

        [Test]
        public void CheckingForDurationOut()
        {
            Assert.That(_nHATSAPIServices.nhatsDTO.NHATSSpecificData.min_dv_traj.dur_out, Is.Not.Null);
        }

    }
}
