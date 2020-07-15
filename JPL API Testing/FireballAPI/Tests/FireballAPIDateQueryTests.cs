using JPL_API_Testing.FireballAPI.FireballAPIService;
using NUnit.Framework;

namespace JPL_API_Testing.FireballAPI
{
    public class FireballAPIDateQueryTests
    {
        private FBAPIService _fBAPIService = new FBAPIService("2019-11-28", "2019-11-29");

        [Test]
        public void CallingAPIReturns_ThreeRecords()
        {
            Assert.That(_fBAPIService.fireballDTO.FireballModel.count, Is.EqualTo("3"));
        }

        [Test]
        public void CallingAPIReturns_DateShouldBeAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Date.Substring(0, 10), Is.EqualTo("2019-11-28"));
            Assert.That(_fBAPIService.fireballData[1].Date.Substring(0, 10), Is.EqualTo("2019-11-28"));
            Assert.That(_fBAPIService.fireballData[2].Date.Substring(0, 10), Is.EqualTo("2019-11-28"));
        }

        [Test]
        public void CallingAPIReturns_EnergyShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Energy, Is.EqualTo("2.7"));
            Assert.That(_fBAPIService.fireballData[1].Energy, Is.EqualTo("2.6"));
            Assert.That(_fBAPIService.fireballData[2].Energy, Is.EqualTo("2.5"));
        }

        [Test]
        public void CallingAPIReturns_ImpactEnergyShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Impacte, Is.EqualTo("0.095"));
            Assert.That(_fBAPIService.fireballData[1].Impacte, Is.EqualTo("0.092"));
            Assert.That(_fBAPIService.fireballData[2].Impacte, Is.EqualTo("0.089"));
        }

        [Test]
        public void CallingAPIReturns_LatShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Lat, Is.EqualTo("35.7"));
            Assert.That(_fBAPIService.fireballData[1].Lat, Is.EqualTo(null));
            Assert.That(_fBAPIService.fireballData[2].Lat, Is.EqualTo("22.1"));
        }

        [Test]
        public void CallingAPIReturns_LatDirectionShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Latdir, Is.EqualTo("N"));
            Assert.That(_fBAPIService.fireballData[1].Latdir, Is.EqualTo(null));
            Assert.That(_fBAPIService.fireballData[2].Latdir, Is.EqualTo("S"));
        }

        [Test]
        public void CallingAPIReturns_LonShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Lon, Is.EqualTo("31.7"));
            Assert.That(_fBAPIService.fireballData[1].Lon, Is.EqualTo(null));
            Assert.That(_fBAPIService.fireballData[2].Lon, Is.EqualTo("25.7"));
        }

        [Test]
        public void CallingAPIReturns_LonDirectionShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Londir, Is.EqualTo("W"));
            Assert.That(_fBAPIService.fireballData[1].Londir, Is.EqualTo(null));
            Assert.That(_fBAPIService.fireballData[2].Londir, Is.EqualTo("E"));
        }

        [Test]
        public void CallingAPIReturns_AltShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Alt, Is.EqualTo("35"));
            Assert.That(_fBAPIService.fireballData[1].Alt, Is.EqualTo(null));
            Assert.That(_fBAPIService.fireballData[2].Alt, Is.EqualTo("22.5"));
        }

        [Test]
        public void CallingAPIReturns_VelShouldAsSpecified()
        {
            Assert.That(_fBAPIService.fireballData[0].Vel, Is.EqualTo("13.0"));
            Assert.That(_fBAPIService.fireballData[1].Vel, Is.EqualTo(null));
            Assert.That(_fBAPIService.fireballData[2].Vel, Is.EqualTo("24.7"));
        }
    }
}
