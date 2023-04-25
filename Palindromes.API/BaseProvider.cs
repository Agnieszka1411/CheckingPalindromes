using System.Linq;


namespace Palindromes.API
{
    public abstract class BaseProvider
    {
        private readonly string[] _InvalidCharacters = new[] { " ", ".", ",", ";", "/", "\\" };

        protected string GetCleanedString(string stringToClean)
        {
            return _InvalidCharacters.Aggregate(stringToClean, (current, c) => current.Replace(c, string.Empty));
        }

        public abstract bool CheckString(string stringToCheck);
    }
}