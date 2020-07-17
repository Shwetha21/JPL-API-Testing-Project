using CadApi.CadApiService;
using NUnit.Framework;

namespace CadApiService.Tests
{
    public class CADTests
    {
        private APIService _cadDataResponse = new APIService();

        [Test]
        public void CallingAPI_ResponseContainsAllRequiredFields()
        {
            Assert.That(_cadDataResponse.cadDTO.CADData, Has.Property("signature"));
            Assert.That(_cadDataResponse.cadDTO.CADData, Has.Property("count"));
            Assert.That(_cadDataResponse.cadDTO.CADData, Has.Property("fields"));
            Assert.That(_cadDataResponse.cadDTO.CADData, Has.Property("data"));
        }

        [Test]
        public void CallingAPI_CorrectSignatureResponse()
        {
            Assert.That(_cadDataResponse.cadDTO.CADData.signature, Has.Property("version"));
            Assert.That(_cadDataResponse.cadDTO.CADData.signature, Has.Property("source"));
        }

        [Test]
        public void CallingAPI_CorrectSourceResponse()
        {
            Assert.That(_cadDataResponse.cadDTO.CADData.signature.source, Is.EqualTo("NASA/JPL SBDB Close Approach Data API"));
        }

        [Test]
        public void CallingAPI_CorrectVersionResponse()
        {
            Assert.That(_cadDataResponse.cadDTO.CADData.signature.version.Substring(0, 3), Is.EqualTo("1.1"));
        }
    }
}