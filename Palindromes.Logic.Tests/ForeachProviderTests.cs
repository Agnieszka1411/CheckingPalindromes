using NUnit.Framework;
using Palindromes.Logic.Providers;

namespace Palindromes.Logic.Tests
{
    public class ForeachProviderTests
    {
        private readonly BaseProvider _foreachProvider = new ForeachProvider();

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
            var actualResult = _foreachProvider.CheckString(userInput);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
