using JPL_API_Testing.JPLAPIService;
using NUnit.Framework;

namespace NHATSAPIProject.NHATSApi.NHATSTestsFolder
{
    public class NHATSTestParameter
    {
        private NHATSAPIServices _nhatsSerivice = new NHATSAPIServices("2016%20TB18","6","360","8","2020-2045");
        private NHATSAPIServices nhatsSerivice = new NHATSAPIServices("2016%20TB18", "0", "360", "8", "2020-2045");
        private NHATSAPIServices nhatsSerivicestay = new NHATSAPIServices("2016%20TB18", "6", "360", "0", "2020-2045");
        private NHATSAPIServices nhatsSerivicedur = new NHATSAPIServices("2016%20TB18", "6", "0", "8", "2020-2045");
        private NHATSAPIServices nhatsSerivicelaunch = new NHATSAPIServices("2016%20TB18", "6", "360", "8", "2020-2100");
        private NHATSAPIServices nhatsSerivicenoparameter = new NHATSAPIServices("2016%20TB18", "0", "0", "0", "0");
        private NHATSAPIServices nhatsSerivicenoparameters = new NHATSAPIServices("2016%20TB18", "", "", "", "");


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

        [Test]
        public void CheckingForErrorMessageWhenStayis0()
        {
            Assert.That(nhatsSerivicestay.nhatsData, Does.Contain("invalid STAY mode value (expecting 8 16 24 32)"));
        }

        [Test]
        public void CheckingForErrorMessagedurationvalueisnull()
        {
            Assert.That(nhatsSerivicedur.nhatsData, Does.Contain("invalid value specified for query parameter 'dur'"));
        }

        [Test]
        public void CheckingForerrormessageWhenlaunchdateIsoutofrange()
        {
            Assert.That(nhatsSerivicelaunch.nhatsData, Does.Contain("invalid value specified for query parameter 'launch'"));
        }

        [Test]
        public void CheckingForErrorMessageWhenEverythingisNull()
        {
            Assert.That(nhatsSerivicenoparameter.nhatsData, Does.Contain("invalid DV mode value (expecting 4 5 6 7 8 9 10 11 12)"));
        }

        [Test]
        public void CheckingForErrorMessageWhenNull()
        {
            Assert.That(nhatsSerivicenoparameters.nhatsData, Does.Contain("invalid DV mode value (expecting 4 5 6 7 8 9 10 11 12)"));
        }
    }

}
