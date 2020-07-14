using JPL_API_Testing.FireballAPI.FireballAPIService;
using NUnit.Framework;

namespace JPL_API_Testing.FireballAPI
{
    public class FireballAPIDataTests
    {
        private FBAPIService _fBAPIService = new FBAPIService();

        [Test]
        public void CallingAPIReturns_PopulatedDate()
        {
            Assert.That(_fBAPIService.fireballData[0].Date, Is.Not.EqualTo(""));
        }

        [Test]
        public void CallingAPIReturns_PopulatedEnergy()
        {
            Assert.That(_fBAPIService.fireballData[0].Energy, Is.Not.EqualTo(""));
        }

        [Test]
        public void CallingAPIReturns_PopulatedImpacte()
        {
            Assert.That(_fBAPIService.fireballData[0].Impacte, Is.Not.EqualTo(""));
        }

        [Test]
        public void CallingAPIReturns_PopulatedLat()
        {
            Assert.That(_fBAPIService.fireballData[0].Lat, Is.Not.EqualTo(""));
        }

        [Test]
        public void CallingAPIReturns_PopulatedLatdir()
        {
            Assert.That(_fBAPIService.fireballData[0].Latdir, Is.Not.EqualTo(""));
        }

        [Test]
        public void CallingAPIReturns_PopulatedLon()
        {
            Assert.That(_fBAPIService.fireballData[0].Lon, Is.Not.EqualTo(""));
        }

        [Test]
        public void CallingAPIReturns_PopulatedLondir()
        {
            Assert.That(_fBAPIService.fireballData[0].Londir, Is.Not.EqualTo(""));
        }

        [Test]
        public void CallingAPIReturns_PopulatedAlt()
        {
            Assert.That(_fBAPIService.fireballData[0].Alt, Is.Not.EqualTo(""));
        }

        [Test]
        public void CallingAPIReturns_PopulatedVel()
        {
            Assert.That(_fBAPIService.fireballData[0].Vel, Is.Not.EqualTo(""));
        }
    }
}