using Palindromes.Logic.Helpers;
using Palindromes.Logic.Providers.Interfaces;

namespace Palindromes.Logic.Providers
{
    public class WhileProvider : IPalindormeProvider
    {
        public bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var cleanedString = InvalidCharactersHelper.GetCleanedString(stringToCheck.ToLower());
            var index = cleanedString.Length - 1;
            var i = 0;

            while (i <= index)
            {
                if (cleanedString[i] == cleanedString[index])
                {
                    i++;
                    index--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}