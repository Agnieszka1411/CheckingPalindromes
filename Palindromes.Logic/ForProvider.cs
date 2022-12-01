using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes.Logic
{
    public class ForProvider : InvalidCharacters, IPalindormeProvider
    {
        public bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
            {
                return false;
            }

            var cleanedString = GetCleanedString(stringToCheck.ToLower());
            int index = cleanedString.Length - 1;

            for (int i = 0; i <= index; i++)
            {
                if (cleanedString[i] == cleanedString[index])
                {
                    index--;
                }
                else
                    return false;
            }
            return true;
        }
    }
}