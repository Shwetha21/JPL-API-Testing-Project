using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using NUnit.Framework;
using JPL_API_Testing.MissionDesignApiService;
using System.Diagnostics.Contracts;

namespace JPL_API_Testing
{
    public class MissionDesignTests
    {
        private MissionDesignService _missionDesignDataResponse = new MissionDesignService();

        [Test]
        public void CallingAPI_ResponseContainsAllRequiredFields()
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData, Has.Property("signature"));
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData, Has.Property("_object"));
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData, Has.Property("dv_lowthrust"));
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData, Has.Property("fields"));
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData, Has.Property("selectedMissions"));
        }

        [Test]
        public void CallingAPI_CorrectSignatureResponse()
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.signature, Has.Property("version"));
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.signature, Has.Property("source"));
        }

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.signature.version.Substring(0,3), Is.EqualTo("1.0"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.signature.source, Is.EqualTo("NASA/JPL Mission Design API"));
        }
    }
}
