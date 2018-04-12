using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daxx.TestTask.Services.Tests
{
    /// <summary>
    /// CharacterConverter Service BL Tests
    /// </summary>
    [TestClass]
    public class CharacterConverterServiceTests
    {
        ICharacterConverterService service;

        [TestInitialize()]
        public void Initialize()
        {
            service = new CharacterConverterService();
        }

        [TestCleanup]
        public void Cleanup()
        {

        }

        [TestMethod]
        public void IloveProgrammingTest()
        {
            var srcString = "I love programming";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == "I evol gnimmargorp");
        }

        [TestMethod]
        public void OneLetterSingleTokenTest()
        {
            var srcString = "a";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == "a");
        }

        [TestMethod]
        public void TwoLettersSingleTokenTest()
        {
            var srcString = "ab";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == "ba");
        }

        [TestMethod]
        public void ThreeLettersSingleTokenTest()
        {
            var srcString = "abc";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == "cba");
        }

        [TestMethod]
        public void EmptyStringTest()
        {
            var srcString = "";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == "");
        }

        [TestMethod]
        public void SingleSpaceTest()
        {
            var srcString = " ";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == " ");
        }

        [TestMethod]
        public void NullSourceTest()
        {
            char[] chars = null;
            service.ReverseTokens(ref chars);
            Assert.IsTrue(chars == null);
        }

        [TestMethod]
        public void LeadingSpaceTest()
        {
            var srcString = " abc";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == " cba");
        }

        [TestMethod]
        public void TrailingSpaceTest()
        {
            var srcString = "abc def ";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == "cba fed ");
        }

        [TestMethod]
        public void DoubleRevesceTest()
        {
            var srcString = "I love programming";
            char[] chars = srcString.ToCharArray();
            service.ReverseTokens(ref chars);
            service.ReverseTokens(ref chars);
            var resultString = new string(chars);
            Assert.IsTrue(resultString == srcString); // result should be the same string after double reversion
        }
    }
}
