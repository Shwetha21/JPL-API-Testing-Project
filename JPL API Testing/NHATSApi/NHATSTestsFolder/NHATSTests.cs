using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using JPL_API_Testing.JPLAPIService;
using NUnit.Framework;

namespace JPL_API_Testing.NHATSApi.NHATSTestsFolder
{
    public class NHATSTests
    {
        private NHATSAPIServices nHATSAPIServices = new NHATSAPIServices();

        [Test]
        public void CheckingWheateherTheSourceIsNhatsDataApi()
        {
            Assert.That(nHATSAPIServices.nhatsDTO.NHATSData.signature.source.Contains("NHATS Data API"), Is.True);
        }

    }
}
