using FireballAPI.FireballAPIService;
using NUnit.Framework;


namespace FireballAPI.Tests
{
    public class FireballAPIEnergyQueryTests
    {
        private FBAPIService _fBAPIService = new FBAPIService("energy", 3);

        [Test]
        public void CallingAPIReturns_ThreeRecords()
        {
            Assert.That(_fBAPIService.fireballDTO.FireballModel.count, Is.EqualTo("3"));
        }

        [TestCase(0, "2020-05-12")]
        [TestCase(1, "2020-01-17")]
        [TestCase(2, "2019-05-22")]
        public void CallingAPIReturns_DateShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Date.Substring(0, 10), Is.EqualTo(expected));
        }

        [TestCase(0, "8.3")]
        [TestCase(1, "9.7")]
        [TestCase(2, "9.5")]
        public void CallingAPIReturns_EnergyShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Energy, Is.EqualTo(expected));
        }

        [TestCase(0, "0.26")]
        [TestCase(1, "0.29")]
        [TestCase(2, "0.29")]
        public void CallingAPIReturns_ImpactEnergyShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Impacte, Is.EqualTo(expected));
        }

        [TestCase(0, "15.9")]
        [TestCase(1, "19.4")]
        [TestCase(2, "10.8")]
        public void CallingAPIReturns_LatitudeShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Lat, Is.EqualTo(expected));
        }

        [TestCase(0, "N")]
        [TestCase(1, "N")]
        [TestCase(2, "N")]
        public void CallingAPIReturns_LatitudeDirectionShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Latdir, Is.EqualTo(expected));
        }

        [TestCase(0, "174.2")]
        [TestCase(1, "66.0")]
        [TestCase(2, "37.3")]
        public void CallingAPIReturns_LongitudeBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Lon, Is.EqualTo(expected));
        }

        [TestCase(0, "E")]
        [TestCase(1, "W")]
        [TestCase(2, "W")]
        public void CallingAPIReturns_LongitudeDirectionShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Londir, Is.EqualTo(expected));
        }

        [TestCase(0, null)]
        [TestCase(1, "14.5")]
        [TestCase(2, "32.6")]
        public void CallingAPIReturns_AltitudeShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Alt, Is.EqualTo(expected));
        }

        [TestCase(0, null)]
        [TestCase(1, "15.5")]
        [TestCase(2, null)]
        public void CallingAPIReturns_VelocityShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Vel, Is.EqualTo(expected));
        }
    }
}
