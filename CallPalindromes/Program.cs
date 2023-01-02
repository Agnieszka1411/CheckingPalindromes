using Palindromes.Logic.Providers;
using System;

namespace CallPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var callPalindrom = new ForeachProvider();

            for (var i = 0; i < args.Length; i++)
            {
                var palindromeToCheck = callPalindrom.CheckString(args[i]);

                Console.WriteLine(palindromeToCheck != true
                    ? $"{args[i]}, {palindromeToCheck} is not a palindrome"
                    : $"{args[i]}, {palindromeToCheck} is a palindrome");

                Console.ReadLine();
            }
        }
    }
}