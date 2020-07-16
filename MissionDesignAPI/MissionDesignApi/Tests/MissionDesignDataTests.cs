using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPL_API_Testing.MissionDesignApiService;
using NUnit.Framework;

namespace JPL_API_Testing.MissionDesignApi.Tests
{
    class MissionDesignDataTests
    {
        private MissionDesignService _missionDesignService = new MissionDesignService();
        [TestCase("MJD0")]
        [TestCase("MJDf")]
        [TestCase("vinf_dep")]
        [TestCase("vinf_arr")]
        [TestCase("phase_ang")]
        [TestCase("earth_dist")]
        [TestCase("elong_arr")]
        [TestCase("decl_dep")]
        [TestCase("approach_ang")]
        [TestCase("tof")]
        public void DataFieldsContainCorrectProperties(string expected)
        {
            Assert.That(_missionDesignService.missionDesignDataList[0], Has.Property(expected));
        }
        [Test]
        public void MJD0DataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].MJD0, Is.Not.Null.Or.Zero); 
        }
        [Test]
        public void MJDfDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].MJDf, Is.Not.Null.Or.Zero); 
        }
        [Test]
        public void vinf_depDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].vinf_dep, Is.Not.Null.Or.Zero); 
        }
        [Test]
        public void vinf_arrDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].vinf_arr, Is.Not.Null.Or.Zero); 
        }
        [Test]
        public void phase_angDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].phase_ang, Is.Not.Null.Or.Zero); 
        }
        [Test]
        public void earth_distDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].earth_dist, Is.Not.Null.Or.Zero); 
        }
        [Test]
        public void elong_arrDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].elong_arr, Is.Not.Null.Or.Zero);
        }
        [Test]
        public void decl_depDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].decl_dep, Is.Not.Null.Or.Zero); 
        }
        [Test]
        public void approach_angDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].approach_ang, Is.Not.Null.Or.Zero); 
        }
        [Test]
        public void TofDataFieldIsNotNull()
        {
            Assert.That(_missionDesignService.missionDesignDataList[0].tof, Is.Not.Null.Or.Zero); 
        }
    }
}
