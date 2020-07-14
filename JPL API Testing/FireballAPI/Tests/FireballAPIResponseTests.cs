using JPL_API_Testing.FireballAPI.FireballAPIService;
using NUnit.Framework;
using System.Linq;

namespace JPL_API_Testing.FireballAPI.Tests
{
    public class FireballAPIResponseTests
    {
        FBAPIService _fBAPIService = new FBAPIService();

        [Test]
        public void CallingAPIReturns_CorrectSource()
        {
            Assert.That(_fBAPIService.fireballDTO.FireballModel.signature.source, Is.EqualTo(@"NASA/JPL Fireball Data API"));
        }

        [Test]
        public void CallingAPIReturns_CorrectVersion()
        {
            Assert.That(_fBAPIService.fireballDTO.FireballModel.signature.version, Is.EqualTo("1.0"));
        }

        [Test]
        public void CallingAPIReturns_FilledData()
        {
            Assert.That(_fBAPIService.fireballDTO.FireballModel.data.Count(), Is.GreaterThan(0));
        }
    }
}
