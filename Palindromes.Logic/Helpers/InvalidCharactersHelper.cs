using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes.Logic.Helpers
{
    public static class InvalidCharactersHelper
    {
        private static readonly string[] _invalidCharacters = new[] { " ", ".", ",", ";", "/", "\\" };
        public static string GetCleanedString(string stringToClean)
        {
            var result = stringToClean;

            foreach (var c in _invalidCharacters)
            {
                result = result.Replace(c, string.Empty);
            }

            return result;
        }
    }
}