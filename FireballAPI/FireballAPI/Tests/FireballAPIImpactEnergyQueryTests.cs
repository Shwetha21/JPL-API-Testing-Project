using FireballAPI.FireballAPIService;
using NUnit.Framework;

namespace FireballAPI.Tests
{
    public class FireballAPIImpactEnergyQueryTests
    {
        private FBAPIService _fBAPIService = new FBAPIService("impact-e", 3);

        [Test]
        public void CallingAPIReturns_ThreeRecords()
        {
            Assert.That(_fBAPIService.fireballDTO.FireballModel.count, Is.EqualTo("3"));
        }

        [TestCase(0, "2019-06-22")]
        [TestCase(1, "2019-02-18")]
        [TestCase(2, "2017-12-15")]
        public void CallingAPIReturns_DateShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Date.Substring(0, 10), Is.EqualTo(expected));
        }

        [TestCase(0, "294.7")]
        [TestCase(1, "195.8")]
        [TestCase(2, "311.4")]
        public void CallingAPIReturns_EnergyShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Energy, Is.EqualTo(expected));
        }

        [TestCase(0, "6")]
        [TestCase(1, "4.2")]
        [TestCase(2, "6.4")]
        public void CallingAPIReturns_ImpactEnergyShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Impacte, Is.EqualTo(expected));
        }

        [TestCase(0, "14.9")]
        [TestCase(1, "15.5")]
        [TestCase(2, "60.2")]
        public void CallingAPIReturns_LatitudeShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Lat, Is.EqualTo(expected));
        }

        [TestCase(0, "N")]
        [TestCase(1, "S")]
        [TestCase(2, "N")]
        public void CallingAPIReturns_LatitudeDirectionShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Latdir, Is.EqualTo(expected));
        }

        [TestCase(0, "66.2")]
        [TestCase(1, "25.3")]
        [TestCase(2, "170.0")]
        public void CallingAPIReturns_LongitudeBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Lon, Is.EqualTo(expected));
        }

        [TestCase(0, "W")]
        [TestCase(1, "E")]
        [TestCase(2, "E")]
        public void CallingAPIReturns_LongitudeDirectionShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Londir, Is.EqualTo(expected));
        }

        [TestCase(0, "25.0")]
        [TestCase(1, "26")]
        [TestCase(2, "20.0")]
        public void CallingAPIReturns_AltitudeShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Alt, Is.EqualTo(expected));
        }

        [TestCase(0, "14.9")]
        [TestCase(1, "20.8")]
        [TestCase(2, "31.4")]
        public void CallingAPIReturns_VelocityShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Vel, Is.EqualTo(expected));
        }
    }
}
