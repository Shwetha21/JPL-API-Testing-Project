using FireballAPI.FireballAPIService;
using NUnit.Framework;

namespace FireballAPI.Tests
{
    public class FireballAPILimitQuery
    {
        private FBAPIService _fBAPIServiceLimitOne = new FBAPIService(1);
        private FBAPIService _fBAPIServiceLimitFive = new FBAPIService(5);
        private FBAPIService _fBAPIServiceLimitTwelve = new FBAPIService(12);
        private FBAPIService _fBAPIServiceLimitThrityFive = new FBAPIService(35);

        [Test]
        public void CallingAPIReturns_LimitShouldBeOne()
        {
            Assert.That(_fBAPIServiceLimitOne.fireballDTO.FireballModel.count, Is.EqualTo("1"));
        }

        [Test]
        public void CallingAPIReturns_LimitShouldBeFive()
        {
            Assert.That(_fBAPIServiceLimitFive.fireballDTO.FireballModel.count, Is.EqualTo("5"));
        }

        [Test]
        public void CallingAPIReturns_LimitShouldBeTwelve()
        {
            Assert.That(_fBAPIServiceLimitTwelve.fireballDTO.FireballModel.count, Is.EqualTo("12"));
        }

        [Test]
        public void CallingAPIReturns_LimitShouldBeThrityFive()
        {
            Assert.That(_fBAPIServiceLimitThrityFive.fireballDTO.FireballModel.count, Is.EqualTo("35"));
        }
    }
}