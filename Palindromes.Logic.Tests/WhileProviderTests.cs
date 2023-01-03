using NUnit.Framework;

namespace Palindromes.Logic.Tests
{
    public class WhileProviderTests
    {
        private readonly WhileProvider _whileProvider = new WhileProvider();

        [Test]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("bleee", false)]
        [TestCase("oko", true)]
        [TestCase("sedes", true)]
        [TestCase("Kobyła ma mały bok.", true)]
        [TestCase("kobyła ma mały bok", true)]
        public void CheckString_APalindromeData_ResultTrue(string userInput, bool expectedResult)
        {
            var actualResult = _whileProvider.CheckString(userInput);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
