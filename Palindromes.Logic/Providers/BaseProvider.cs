using System.Linq;

namespace Palindromes.Logic
{
    public abstract class BaseProvider
    {
        private readonly string[] _invalidCharacters = new[] { " ", ".", ",", ";", "/", "\\" };

        protected string GetCleanedString(string stringToClean)
        {
            return _invalidCharacters.Aggregate(stringToClean, (current, c) => current.Replace(c, string.Empty));
        }

        public abstract bool CheckString(string stringToCheck);
    }
}