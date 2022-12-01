using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindromes.Logic.Tests
{
    [TestClass]
    public class DoWhileProviderTests
    {
        private readonly DoWhileProvider _doWhileProvider = new DoWhileProvider();

        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("bleee", false)]
        [DataRow("oko", true)]
        [DataRow("sedes", true)]
        [DataRow("Kobyła ma mały bok.", true)]
        [DataRow("kobyła ma mały bok", true)]

        [TestMethod]
        public void CheckString_APalindromeData_ResultTrue(string userInput, bool expectedResult)
        {
            bool actualResult = _doWhileProvider.CheckString(userInput);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
