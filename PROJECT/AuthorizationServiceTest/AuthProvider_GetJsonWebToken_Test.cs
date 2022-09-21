using AuthorizationService.Providers;
using AuthorizationService.Repository;
using Moq;
using NUnit.Framework;

namespace AuthorizationServiceTest
{
    class AuthProvider_GetJsonWebToken_Test
    {

        public string token_not_null;
        public string token_null;
        [SetUp]
        public void Setup()
        {
            token_not_null = "xhagssbmfbdmsdjfbkalalasknasncjafh";
            token_null = null;

        }

        [Test]
        public void provider_generateJWT_correctInput_tokenNotnull()
        {
            var mock = new Mock<IAuthRepo>();
            mock.Setup(p => p.GenerateJWT()).Returns(token_not_null);
            var res = new AuthProvider(mock.Object);
            var data = res.GetJsonWebToken();
            Assert.AreEqual(token_not_null, data);
        }
        [Test]
        public void provider_generateJWT_correctInput_tokenNull()
        {
            var mock = new Mock<IAuthRepo>();
            mock.Setup(p => p.GenerateJWT()).Returns(token_null);
            var res = new AuthProvider(mock.Object);
            var data = res.GetJsonWebToken();
            Assert.AreEqual(null, data);
        }
    }
}
