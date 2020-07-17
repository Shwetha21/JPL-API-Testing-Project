using NUnit.Framework;
using SentryAPI.SentrydesDataApiService;

namespace SentryAPI.Tests
{
    public class SentrydesTests
    {
        private SentrydesDataAPIService _sentryDataApiService = new SentrydesDataAPIService(29075);

        [Test]
        public void checkdesEnergy()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.energy, Is.EqualTo("7.538e+04"));
        }

        [Test]
        public void checkdesDarc()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.darc, Is.EqualTo("24010.3 days"));
        }

        [Test]
        public void checkdesIp()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.ip, Is.EqualTo("1.2e-04"));
        }

        [Test]
        public void checkdesH()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.h, Is.EqualTo("17.55"));
        }

        [Test]
        public void checkdesNobs()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.nobs, Is.EqualTo("523"));
        }

        [Test]
        public void checkMass()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.mass, Is.EqualTo("1.96e+12"));
        }

        [Test]
        public void checkV_inf()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.v_inf, Is.EqualTo("14.10"));
        }

        [Test]
        public void checkFirst_obs()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.first_obs, Is.EqualTo("1950-Feb-22.230140"));
        }

        [Test]
        public void checkMethod()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.method, Is.EqualTo("LOV"));
        }

        [Test]
        public void checkPdate()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.pdate, Is.Not.Null.Or.Zero);
        }

        [Test]
        public void checkNdop()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.ndop, Is.EqualTo("4"));
        }

        [Test]
        public void checkCdate()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.cdate, Is.EqualTo("2015-12-07 14:30:02"));
        }

        [Test]
        public void checkPs_cum()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.ps_cum, Is.EqualTo("-1.42"));
        }

        [Test]
        public void checkDiameter()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.diameter, Is.EqualTo("1.3e+00"));
        }

        [Test]
        public void checkNdel()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.ndel, Is.EqualTo("8"));
        }

        [Test]
        public void checkV_imp()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.v_imp, Is.EqualTo("17.99"));
        }

        [Test]
        public void checkPs_max()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.ps_max, Is.EqualTo("-1.42"));
        }

        [Test]
        public void checkLast_obs()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.last_obs, Is.EqualTo("2015-Nov-18.504940"));
        }

        [Test]
        public void checkFullname()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.fullname, Is.EqualTo("29075 (1950 DA)"));
        }

        [Test]
        public void checkN_imp()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.n_imp, Is.EqualTo("1"));
        }

        [Test]
        public void checkTs_max()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.ts_max, Is.EqualTo(null));
        }

        [Test]
        public void checknsat()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.nsat, Is.EqualTo("0"));
        }

        [Test]
        public void checkDes()
        {
            Assert.That(_sentryDataApiService.SentryDataDTO.desData.summary.des, Is.EqualTo("29075"));
        }
    }
}