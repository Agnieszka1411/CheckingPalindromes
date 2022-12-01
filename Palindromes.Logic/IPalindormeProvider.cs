using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes.Logic
{
    public interface IPalindormeProvider
    {
        bool CheckString(string userInput);
    }
}
