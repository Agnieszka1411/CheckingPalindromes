using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes.Logic
{
    public abstract class InvalidCharacters
    {
        private readonly string[] _invalidCharacters = new[] { " ", ".", ",", ";", "/", "\\" };
        protected string GetCleanedString(string stringToClean)
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