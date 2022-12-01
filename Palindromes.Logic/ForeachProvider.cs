using System;

namespace Palindromes.Logic
{
    public class ForeachProvider : InvalidCharacters, IPalindormeProvider
    {
        public bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
            {
                return false;
            }

            var cleanedString = GetCleanedString(stringToCheck.ToLower());

            int index = cleanedString.Length - 1;

            foreach (var element in cleanedString)
            {
                if (element == cleanedString[index])
                {
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
