using JPL_API_Testing.JPLAPIService;
using NUnit.Framework;

namespace NHATSAPIProject.NHATSApi.NHATSTestsFolder
{
    public class NHATSTestParameter
    {
        private NHATSAPIServices _nhatsSerivice = new NHATSAPIServices("2016%20TB18","6","360","8","2020-2045");
        private NHATSAPIServices nhatsSerivice = new NHATSAPIServices("2016%20TB18", "0", "360", "8", "2020-2045");

        [Test]
        public void CheckingForCorrectresponseWhenCorrectDataIsgiven()
        {
            Assert.That(_nhatsSerivice.nhatsDTO.NHATSSpecificData.des, Is.EqualTo("2016 TB18"));
        }

        [Test]
        public void CheckingForErrorMessageWhenvelocityvalueis0()
        {
            Assert.That(nhatsSerivice.nhatsData, Does.Contain("invalid DV mode value (expecting 4 5 6 7 8 9 10 11 12)"));
        }
    }

}
