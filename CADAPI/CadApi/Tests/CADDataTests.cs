using CadApi.CadApiService;
using NUnit.Framework;

namespace CadApi.Tests
{
    internal class CADDataTests
    {
        private APIService _cadService = new APIService();

        [TestCase("des")]
        [TestCase("orbit_id")]
        [TestCase("jd")]
        [TestCase("cd")]
        [TestCase("dist")]
        [TestCase("dist_min")]
        [TestCase("dist_max")]
        [TestCase("v_rel")]
        [TestCase("v_inf")]
        [TestCase("t_sigma_f")]
        [TestCase("h")]
        public void DataFieldsContainCorrectProperties(string expected)
        {
            Assert.That(_cadService.cadDataList[0], Has.Property(expected));
        }

        [Test]
        public void desDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].des, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void objectIdDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].orbit_id, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void jdDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].jd, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void cdDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].cd, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void distDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].dist, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void distMinDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].dist_min, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void distMaxDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].dist_max, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void vRelDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].v_rel, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void vInfDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].v_inf, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void tSigmaDataFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].t_sigma_f, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void hFieldIsNotNull()
        {
            Assert.That(_cadService.cadDataList[0].h, Is.Not.Null.Or.Empty);
        }
    }
}