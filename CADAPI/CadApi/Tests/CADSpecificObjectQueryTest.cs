using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPL_API_Testing.JPLAPIService;
using NUnit.Framework;

namespace CADAPI.CadApi.Tests
{
    class CADSpecificObjectQueryTest
    {
        private APIService _cadService = new APIService(3745588);
        
        [Test]
        public void CallingUniqueSPK_ReturnsOneResult()
        {
            Assert.That(_cadService.cadDataList.Count(), Is.EqualTo(1));
        }
    }
}
