using Palindromes.Logic.Helpers;
using Palindromes.Logic.Providers.Interfaces;

namespace Palindromes.Logic.Providers
{
    public class ForProvider : IPalindormeProvider
    {
        public bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var cleanedString = InvalidCharactersHelper.GetCleanedString(stringToCheck.ToLower());
            var index = cleanedString.Length - 1;

            for (var i = 0; i <= index; i++)
            {
                if (cleanedString[i] == cleanedString[index])
                    index--;
                else
                    return false;
            }
            return true;
        }
    }
}