using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JPL_API_Testing.SbdbApiService;
using JPL_API_Testing.SbdbApiService.DataHandling;
using System.Security.Cryptography;

namespace JPL_API_Testing.SbdbApi.Tests
{
    class SbdbAmorAsteroidTests
    {
        private SbdbService _sbdbDataResponse = new SbdbService("2015ab");

        [Test]
        public void AmorOrbitSource_ReturnsCorrectSource()                //Source of the information
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.source.ToString(), Is.EqualTo("JPL"));
        }
        [Test]
        public void AmorOrbitCovarianceEpoch_ReturnsExpected()         //The time frame of the asteroids course
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.cov_epoch, Is.EqualTo("2457009.5"));
        }
        [Test]
        public void AmorOrbitMOIDToJupiter_ReturnsExpected()                //MOID - Minimum Orbit Intersection Distance
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.moid_jup, Is.EqualTo("3.06"));
        }
        [Test]
        public void AmorOrbitTrisserand_ReturnsExpected()              //A value to categories the type of orbit
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.t_jup, Is.EqualTo("3.994"));
        }
        [Test]
        public void AmorOrbitConditionCode_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.condition_code, Is.EqualTo("1"));
        }
        [Test]
        public void AmorOrbitClassNotValidBeforeDate_IsNull()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.not_valid_before, Is.Null);
        }
        [Test]
        public void AmorOrbitRootMeanSquareValue_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.rms, Is.EqualTo("0.61"));
        }
        [Test]
        public void AmorOrbitsModelParameters_ReturnsEmptyArray()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.model_pars, Is.Empty);
        }
        [Test]
        public void AmorOrbitOrbitID_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.orbit_id, Is.EqualTo("16"));
        }
        [Test]
        public void AmorOrbitOrbitID_MatchesAmorObjectOrbitID()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.orbit_id, Is.EqualTo(_sbdbDataResponse.json_sbdb["object"]["orbit_id"].ToString()));
        }
        [Test]
        public void AmorOrbitProducterName_ReturnsOttoMatic()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.producer, Is.EqualTo("Otto Matic"));
        }
        [Test]
        public void AmorOrbitFirstObservationDate_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.first_obs, Is.EqualTo("2009-09-15"));
        }
        [Test]
        public void AmorOrbitSolutionDate_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.soln_date, Is.EqualTo("2020-03-29 05:54:27"));
        }
        [Test]
        public void AmorOrbitTwoBodyModelValue_IsNull()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.two_body, Is.Null);
        }
        [Test]
        public void AmorOrbitEpochOfOsculation_ReturnsExpectedValue()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.epoch, Is.EqualTo("2459000.5"));
        }
        [Test]
        public void AmorElementsArray_ContainsAllElevenElements()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements.Count(), Is.EqualTo(11));
        }
        [Test]
        public void AmorOrbitEquinoxReference_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.equinox, Is.EqualTo("J2000"));
        }
        [Test]
        public void OrbitObservedPeriodInDays_ReturnsExected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.data_arc, Is.EqualTo("3848"));
        }
        [Test]
        public void OrbitNotValidAfterDateEntry_IsNull()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.not_valid_after, Is.Null);
        }
        [Test]
        public void AmorOrbitPerturberEphemerisCategorisation_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.sb_used, Is.EqualTo("SB431-N16"));
        }
        [Test]
        public void AmorOrbitRadarDelayInformation_IsNull()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.n_del_obs_used, Is.Null);
        }
        [Test]
        public void OrbitClassHasOverallObservationCount()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.n_obs_used, Is.EqualTo("54"));
        }
        [Test]
        public void AmorOrbitComment_IsNull()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.comment, Is.Null);
        }
        [Test]
        public void AmorOrbitPlanetaryEphemerisCategorisation_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.pe_used, Is.EqualTo("DE431"));
        }
        [Test]
        public void AmorOrbitLastObservationDate_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.last_obs, Is.EqualTo("2020-03-29"));
        }
        [Test]
        public void AmorOrbitClassMOIDToEarth_ReturnsExpected()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.moid, Is.EqualTo("0.365"));
        }
        [Test]
        public void AmorOrbitRadarDopplerInformation_IsNull()
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.n_dop_obs_used, Is.Null);
        }
        [TestCase(0, "e")]
        [TestCase(1, "a")]
        [TestCase(2, "q")]
        [TestCase(3, "i")]
        [TestCase(4, "om")]
        [TestCase(5, "w")]
        [TestCase(6, "ma")]
        [TestCase(7, "tp")]
        [TestCase(8, "per")]
        [TestCase(9, "n")]
        [TestCase(10, "ad")]
        public void AmorElementsArray_ContainsCorrectElementNames(int element, string expected)
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[element].name, Is.EqualTo(expected));
        }
        [TestCase(0, null)]
        [TestCase(1, "au")]
        [TestCase(2, "au")]
        [TestCase(3, "deg")]
        [TestCase(4, "deg")]
        [TestCase(5, "deg")]
        [TestCase(6, "deg")]
        [TestCase(7, "TDB")]
        [TestCase(8, "d")]
        [TestCase(9, "deg/d")]
        [TestCase(10, "au")]
        public void AmorElementsArray_ContainsCorrectElementUnits(int element, string expected)
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[element].units, Is.EqualTo(expected));
        }
        [TestCase(0, "0.284")]
        [TestCase(1, "1.8")]
        [TestCase(2, "1.29")]
        [TestCase(3, "11.6")]
        [TestCase(4, "0.412")]
        [TestCase(5, "71.4")]
        [TestCase(6, "100")]
        [TestCase(7, "2458754.478")]
        [TestCase(8, "883")]
        [TestCase(9, "0.408")]
        [TestCase(10, "2.31")]
        public void AmorElementsArray_ContainsExpectedElementValue(int element, string expected)
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[element].value, Is.EqualTo(expected));
        }
        [TestCase(0, "3.7e-07")]
        [TestCase(1, "6.9e-08")]
        [TestCase(2, "6.2e-07")]
        [TestCase(3, "1.7e-05")]
        [TestCase(4, "5.9e-05")]
        [TestCase(5, "6.2e-05")]
        [TestCase(6, "7.9e-05")]
        [TestCase(7, "0.00018")]
        [TestCase(8, "5.1e-05")]
        [TestCase(9, "2.4e-08")]
        [TestCase(10, "8.9e-08")]
        public void AmorElementsArray_ContainsExpectedElementSigmaValue(int element, string expected)
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[element].sigma, Is.EqualTo(expected));
        }
        [TestCase(0, "eccentricity")]
        [TestCase(1, "semi-major axis")]
        [TestCase(2, "perihelion distance")]
        [TestCase(3, "inclination; angle with respect to x-y ecliptic plane")]
        [TestCase(4, "longitude of the ascending node")]
        [TestCase(5, "argument of perihelion")]
        [TestCase(6, "mean anomaly")]
        [TestCase(7, "time of perihelion passage")]
        [TestCase(8, "sidereal orbital period")]
        [TestCase(9, "mean motion")]
        [TestCase(10, "aphelion distance")]
        public void AmorElementsArray_ContainsCorrectElementTitle(int element, string expected)
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[element].title, Is.EqualTo(expected));
        }
        [TestCase(0, "e")]
        [TestCase(1, "a")]
        [TestCase(2, "q")]
        [TestCase(3, "i")]
        [TestCase(4, "node")]
        [TestCase(5, "peri")]
        [TestCase(6, "M")]
        [TestCase(7, "tp")]
        [TestCase(8, "period")]
        [TestCase(9, "n")]
        [TestCase(10, "Q")]
        public void AmorElementsArray_ContainsCorrectElementLabel(int element, string expected)
        {
            Assert.That(_sbdbDataResponse.sbdbDTO.SbdbData.orbit.elements[element].label, Is.EqualTo(expected));
        }
        [Test]
        public void AmorIsAnNEO()
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["neo"].ToString(), Is.EqualTo("True"));
        }
        [Test]
        public void AmorIsNotAPHA()           //PHA - Potentially Hazardous Asteroid
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["pha"].ToString(), Is.EqualTo("False"));
        }
        [Test]
        public void AmorSpkIDTag_ReturnsExpected()                //SPK ID - ID code to identify a body and its centre of motion
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["spkid"].ToString(), Is.EqualTo("3467168"));
        }
        [Test]
        public void AmorIsAnUnNumberedAsteroid()     //Kind - Whether the asteroid or comet is numbered (an/cn) or not (au/cu) 
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["kind"].ToString(), Is.EqualTo("au"));
        }
        [Test]
        public void AmorOrbitId_ReturnsExpected()        //A unique code to identify the orbit solution
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["orbit_id"].ToString(), Is.EqualTo("16"));
        }
        [Test]
        public void AmorFullObjectName_Returns2015AB()
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["fullname"].ToString(), Is.EqualTo("(2015 AB)"));
        }
        [Test]
        public void AmorDesignationCode_Returns2015AB()        //Naming convention giving the date of discovery.
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["des"].ToString(), Is.EqualTo("2015 AB"));
        }
        [Test]
        public void AmorPrefix_IsNull()   //Null for asteroids, designate the time of the year.
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["prefix"], Is.Null.Or.Empty);
        }
        [Test]
        public void AmorIsTheGivenNameFor2015AB()
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["orbit_class"]["name"].ToString(), Is.EqualTo("Amor"));
        }
        [Test]
        public void AmorHasCode_ReturnsAMO()
        {
            Assert.That(_sbdbDataResponse.json_sbdb["object"]["orbit_class"]["code"].ToString(), Is.EqualTo("AMO"));
        }
    }
}

