using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes.Logic
{
    public class DoWhileProvider : InvalidCharacters, IPalindormeProvider
    {
        public bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
            {
                return false;
            }

            var cleanedString = GetCleanedString(stringToCheck.ToLower());
            int index = cleanedString.Length - 1;
            int i = 0;

            do
            {
                if (cleanedString[i] == cleanedString[index])
                {
                    i++;
                    index--;
                }
                else
                    return false;
            } while (i <= index);

            return true;
        }
    }
}