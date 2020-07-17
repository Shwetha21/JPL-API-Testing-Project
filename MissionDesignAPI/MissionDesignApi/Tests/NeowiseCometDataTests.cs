using MissionDesignApi.MissionDesignApiService;
using NUnit.Framework;
using System.Linq;

namespace MissionDesignAPI.MissionDesignApi.Tests
{
    internal class NeowiseCometDataTests
    {
        private MissionDesignService _missionDesignService = new MissionDesignService("C/2020 F3");

        [Test]
        public void DataArc_ReturnsExpectedValue()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["data_arc"].ToString(), Is.EqualTo("70"));
        }

        [Test]
        public void Md_Orbit_Id_ReturnsExpectedValue()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["md_orbit_id"].ToString(), Is.EqualTo("11"));
        }

        [Test]
        public void orbit_Class_ReturnsCorrectCode()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["orbit_class"].ToString(), Is.EqualTo("COM"));
        }

        [Test]
        public void SpkId_ReturnsCorrectCode()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["spkid"].ToString(), Is.EqualTo("1003667"));
        }

        [Test]
        public void Condition_Code_IsNullOrEmpty()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["condition_code"], Is.Null.Or.Empty);
        }

        [Test]
        public void OrbitId_ReturnsExpectedValue()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["orbit_id"].ToString(), Is.EqualTo("11"));
        }

        [Test]
        public void OrbitId_MatchesMD_OrbitID()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["orbit_id"].ToString(), Is.EqualTo(_missionDesignService.json_MissionDesign["object"]["md_orbit_id"].ToString()));
        }

        [Test]
        public void FullName_ReturnsNeowiseAndClassification()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["fullname"].ToString(), Is.EqualTo("C/2020 F3 (NEOWISE)"));
        }

        [Test]
        public void Designation_ReturnsCorrectCode()
        {
            Assert.That(_missionDesignService.json_MissionDesign["object"]["des"].ToString(), Is.EqualTo("2020 F3"));
        }

        [Test]
        public void SelectedMissionsCount_IsFour()
        {
            Assert.That(_missionDesignService.missionDesignDataList.Count(), Is.EqualTo(4));
        }

        [Test]
        public void Dv_LowthrustConst_ReturnsExpectedValues()
        {
            Assert.That(_missionDesignService.json_MissionDesign["dv_lowthrust"]["const"].ToString(), Is.EqualTo("31.6102"));
        }

        [Test]
        public void Dv_LowhrustSep_ReturnsExpectedValues()
        {
            Assert.That(_missionDesignService.MissionDesignDTO.MissionDesignData.dv_lowthrust.sep.ToString(), Is.EqualTo("2381.85"));
        }

        [TestCase(0, "58849")]
        [TestCase(1, "58849")]
        [TestCase(2, "58940")]
        [TestCase(3, "58849")]
        public void EachSelectedMission_HasCorrectLaunchDate(int mission, string expected)
        {
            Assert.That(_missionDesignService.missionDesignDataList[mission].MJD0.ToString(), Is.EqualTo(expected));
        }

        [TestCase(0, "59380")]
        [TestCase(1, "59380")]
        [TestCase(2, "59030")]
        [TestCase(3, "59163")]
        public void EachSelectedMission_HasCorrectArrivalDate(int mission, string expected)
        {
            Assert.That(_missionDesignService.missionDesignDataList[mission].MJDf.ToString(), Is.EqualTo(expected));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void DifferenceBetweenLaunchAndArrival_EqualsTimeOfFlight(int mission)
        {
            int result = (int)(_missionDesignService.missionDesignDataList[mission].MJDf - _missionDesignService.missionDesignDataList[mission].MJD0);
            Assert.That((int)_missionDesignService.missionDesignDataList[mission].tof, Is.EqualTo(result));
        }
    }
}