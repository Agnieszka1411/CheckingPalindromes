using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes.Logic
{
    public class WhileProvider : InvalidCharacters, IPalindormeProvider
    {
        public bool CheckString(string stringToCheck)
        {
            if (String.IsNullOrWhiteSpace(stringToCheck))
            {
                return false;
            }

            var cleanedString = GetCleanedString(stringToCheck.ToLower());
            int index = cleanedString.Length - 1;
            int i = 0;

            while (i <= index)
            {
                if (cleanedString[i] == cleanedString[index])
                {
                    i++;
                    index--;
                }
                else
                    return false;
            }

            return true;
        }
    }
}