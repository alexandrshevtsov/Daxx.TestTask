using Daxx.TestTask.Services;
using Daxx.TestTask.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daxx.TestTask.Web.Tests
{
    /// <summary>
    /// Integration tests for CharacterConverterController
    /// </summary>
    [TestClass]
    public class CharacterConverterControllerTests
    {
        CharacterConverterController controller;

        [TestInitialize()]
        public void Initialize()
        {
            controller = new CharacterConverterController(new CharacterConverterService());
        }

        [TestCleanup]
        public void Cleanup()
        {

        }

        [TestMethod]
        public void ReverseTokensTest()
        {
            var result = controller.ReverseTokens("I love .net");
            Assert.IsTrue(result == "I evol ten.");
        }
    }
}
