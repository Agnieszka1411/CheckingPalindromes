using NUnit.Framework;
using Palindromes.Logic.Providers;

namespace Palindromes.Logic.Tests
{
    public class DoWhileProviderTests
    {
        private readonly BaseProvider _doWhileProvider = new DoWhileProvider();

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
            var actualResult = _doWhileProvider.CheckString(userInput);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
