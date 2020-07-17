using MissionDesignApi.MissionDesignApiService;
using NUnit.Framework;

namespace MissionDesignApi.Tests
{
    public class MissionDesignTests
    {
        private MissionDesignService _missionDesignDataResponse = new MissionDesignService("C/2020 F3");

        [TestCase("signature")]
        [TestCase("_object")]
        [TestCase("dv_lowthrust")]
        [TestCase("fields")]
        [TestCase("selectedMissions")]
        public void CallingAPI_ResponseContainsAllRequiredFields(string expected)
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData, Has.Property(expected));
        }

        [TestCase("version")]
        [TestCase("source")]
        public void CallingAPI_CorrectSignatureResponse(string expected)
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.signature, Has.Property(expected));
        }

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.signature.version.Substring(0, 3), Is.EqualTo("1.0"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.signature.source, Is.EqualTo("NASA/JPL Mission Design API"));
        }

        [TestCase("sep")]
        [TestCase("_const")]
        public void Dv_LowthrustHasCorrectProperties(string expected)
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.dv_lowthrust, Has.Property(expected));
        }

        [TestCase("data_arc")]
        [TestCase("md_orbit_id")]
        [TestCase("orbit_class")]
        [TestCase("spkid")]
        [TestCase("condition_code")]
        [TestCase("orbit_id")]
        [TestCase("fullname")]
        [TestCase("des")]
        public void ObjectHasCorrectProperties(string expected)
        {
            Assert.That(_missionDesignDataResponse.json_MissionDesign["object"].ToString(), Does.Contain(expected));
        }
    }
}