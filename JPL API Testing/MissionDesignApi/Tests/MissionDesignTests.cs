using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using NUnit.Framework;
using JPL_API_Testing.MissionDesignApiService;

namespace JPL_API_Testing
{
    public class MissionDesignTests
    {
        private MissionDesignService _missionDesignDataResponse = new MissionDesignService();

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_missionDesignDataResponse.MissionDesignDTO.MissionDesignData.signature.version.Substring(0,3), Is.EqualTo("1.0"));
        }
    }
}
