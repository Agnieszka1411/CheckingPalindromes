using Palindromes.Logic.Helpers;
using Palindromes.Logic.Providers.Interfaces;

namespace Palindromes.Logic.Providers
{
    public class ForeachProvider : IPalindormeProvider
    {
        public bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var cleanedString = InvalidCharactersHelper.GetCleanedString(stringToCheck.ToLower());

            var index = cleanedString.Length - 1;

            foreach (var element in cleanedString)
            {
                if (element == cleanedString[index])
                    index--;
                else
                    return false;
            }

            return true;
        }
    }
}
