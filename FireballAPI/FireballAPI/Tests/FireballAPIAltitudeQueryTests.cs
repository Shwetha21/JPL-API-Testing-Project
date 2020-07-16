using FireballAPI.FireballAPIService;
using NUnit.Framework;

namespace FireballAPI.Tests
{
    public class FireballAPIAltitudeQueryTests
    {
        private FBAPIService _fBAPIService = new FBAPIService("altitude", 3);

        [Test]
        public void CallingAPIReturns_ThreeRecords()
        {
            Assert.That(_fBAPIService.fireballDTO.FireballModel.count, Is.EqualTo("3"));
        }

        [TestCase(0, "2020-03-26")]
        [TestCase(1, "2020-02-28")]
        [TestCase(2, "2020-02-10")]
        public void CallingAPIReturns_DateShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Date.Substring(0, 10), Is.EqualTo(expected));
        }

        [TestCase(0, "12.4")]
        [TestCase(1, "11.5")]
        [TestCase(2, "2.7")]
        public void CallingAPIReturns_EnergyShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Energy, Is.EqualTo(expected));
        }

        [TestCase(0, "0.37")]
        [TestCase(1, "0.34")]
        [TestCase(2, "0.095")]
        public void CallingAPIReturns_ImpactEnergyShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Impacte, Is.EqualTo(expected));
        }

        [TestCase(0, "38.3")]
        [TestCase(1, "45.7")]
        [TestCase(2, "28.2")]
        public void CallingAPIReturns_LatitudeShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Lat, Is.EqualTo(expected));
        }

        [TestCase(0, "S")]
        [TestCase(1, "N")]
        [TestCase(2, "N")]
        public void CallingAPIReturns_LatitudeDirectionShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Latdir, Is.EqualTo(expected));
        }

        [TestCase(0, "23.5")]
        [TestCase(1, "15.1")]
        [TestCase(2, "76.7")]
        public void CallingAPIReturns_LongitudeBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Lon, Is.EqualTo(expected));
        }

        [TestCase(0, "E")]
        [TestCase(1, "E")]
        [TestCase(2, "E")]
        public void CallingAPIReturns_LongitudeDirectionShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Londir, Is.EqualTo(expected));
        }

        [TestCase(0, "26.5")]
        [TestCase(1, "34.5")]
        [TestCase(2, "41.7")]
        public void CallingAPIReturns_AltitudeShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Alt, Is.EqualTo(expected));
        }

        [TestCase(0, "20.7")]
        [TestCase(1, "21.5")]
        [TestCase(2, "31.7")]
        public void CallingAPIReturns_VelocityShouldBeAsSpecified(int index, string expected)
        {
            Assert.That(_fBAPIService.fireballData[index].Vel, Is.EqualTo(expected));
        }
    }
}
