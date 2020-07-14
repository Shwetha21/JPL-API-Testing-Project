using JPL_API_Testing.FireballAPI.FireballAPIService;
using NUnit.Framework;

namespace JPL_API_Testing.FireballAPI
{
    public class FireballAPILimitQuery
    {
        private FBAPIService _fBAPIService = new FBAPIService(1, "2019-11-28", "2019-11-29");

        [Test]
        public void CallingAPIReturns_LimitShouldBeOne()
        {
            Assert.That(_fBAPIService.fireballDTO.FireballModel.count, Is.EqualTo("1"));
        }

        [Test]
        public void CallingAPIReturns_DateShouldBeAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Date.Substring(0, 10), Is.EqualTo("2019-11-28"));
        }

        [Test]
        public void CallingAPIReturns_EnergyShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Energy, Is.EqualTo("2.7"));
        }

        [Test]
        public void CallingAPIReturns_ImpactEnergyShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Impacte, Is.EqualTo("0.095"));
        }

        [Test]
        public void CallingAPIReturns_LatShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Lat, Is.EqualTo("35.7"));
        }

        [Test]
        public void CallingAPIReturns_LatDirectionShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Latdir, Is.EqualTo("N"));
        }

        [Test]
        public void CallingAPIReturns_LonShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Lon, Is.EqualTo("31.7"));
        }

        [Test]
        public void CallingAPIReturns_LonDirectionShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Londir, Is.EqualTo("W"));
        }

        [Test]
        public void CallingAPIReturns_AltShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Alt, Is.EqualTo("35"));
        }

        [Test]
        public void CallingAPIReturns_VelShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Vel, Is.EqualTo("13.0"));
        }
    }
}