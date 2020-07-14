using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JPL_API_Testing.SbdbApiService;

namespace JPL_API_Testing.SbdbApi.Tests
{
    class SbdbOrbitTests
    {
        private SbdbService _sbdbDataResponse = new SbdbService();

        [Test]
        public void OrbitClassHasCorrectSource()                //Source of the information
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("source"));
        }
        [Test]
        public void OrbitClassHasCovarianceEpochField()         //The time frame of the asteroids course
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("cov_epoch"));
        }
        [Test]
        public void OrbitClassHasMOIDToJupiter()                //MOID - Minimum Orbit Intersection Distance
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("moid_jup"));
        }
        [Test]
        public void OrbitClassHasTrisserandField()              //A value to categories the type of orbit
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("t_jup"));
        }
        [Test]
        public void OrbitClassHasConditionCode()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("condition_code"));
        }
        [Test]
        public void OrbitClassHasNotValidBeforeDateEntry()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("not_valid_after"));
        }
        [Test]
        public void OrbitClassHasRootMeanSquareValue()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("rms"));
        }
        [Test]
        public void OrbitClassHasModelParameters()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("model_pars"));
        }
        [Test]
        public void OrbitClassHasOrbitID()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("orbit_id"));
        }
        //[Test]
        //public void OrbitClassObjectId_MatchesObjectClassOrbitId()
        //{
        //    Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.orbit_id, Is.EqualTo(_sbdbDataResponse.sbdbDTO.SbdbData._object.orbit_id));
        //}
        [Test]
        public void OrbitClassHasProducterName()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("producer"));
        }
        [Test]
        public void OrbitClassHasFirstObservationDate()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("first_obs"));
        }
        [Test]
        public void OrbitClassHasSolutionDate()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("soln_date"));
        }
        [Test]
        public void OrbitClassHasTwoBodyModelValue()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("two_body"));
        }
        [Test]
        public void OrbitClassHasEpochOfOsculation()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("epoch"));
        }
        [Test]
        public void OrbitClassHasElementsArray()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("elements"));
        }
        [Test]
        public void OrbitClassHasAnEquinoxReference()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("equinox"));
        }
        [Test]
        public void OrbitClassHasObservedPeriodInDays()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("data_arc"));
        }
        [Test]
        public void OrbitClassHasNotValidAfterDateEntry()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("not_valid_after"));
        }
        [Test]
        public void OrbitClassHasPerturberEphemerisCategorisation()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("sb_used"));
        }
        [Test]
        public void OrbitClassHasRadarDelayInformation()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("n_del_obs_used"));
        }
        [Test]
        public void OrbitClassHasOverallObservationCount()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("n_obs_used"));
        }
        [Test]
        public void OrbitClassHasACommentField()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("comment"));
        }
        [Test]
        public void OrbitClassHasPlanetaryEphemerisCategorisation()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("pe_used"));
        }
        [Test]
        public void OrbitClassHasLastObservationDate()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("last_obs"));
        }
        [Test]
        public void OrbitClassHasMOIDToEarth()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("moid"));
        }
        [Test]
        public void OrbitClassHasRadarDopplerInformation()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit, Has.Property("n_dop_obs_used"));
        }
        [Test]
        public void OrbitClassElementsHasUnitsProperty()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[0], Has.Property("units"));
        }
        [Test]
        public void OrbitClassElementsHasName()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[0], Has.Property("name"));
        }
        [Test]
        public void OrbitClassElementsHasValue()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[0], Has.Property("value"));
        }
        [Test]
        public void OrbitClassElementsHasSigmaValue()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[0], Has.Property("sigma"));
        }
        [Test]
        public void OrbitClassElementsHasTitle()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[0], Has.Property("title"));
        }
        [Test]
        public void OrbitClassElementsHasLabel()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[0], Has.Property("label"));
        }
    }
}
