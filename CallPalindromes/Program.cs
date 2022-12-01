using System;
using Palindromes.Logic;

namespace CallPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var callPalindrom = new ForeachProvider();

            for (int i = 0; i<args.Length; i++)
            {
                var palindromToCheck = callPalindrom.CheckString(args[i]);

                if (palindromToCheck != true)
                {
                    Console.WriteLine(args[i] + ", " + palindromToCheck + " - Is not a palindrome");
                }
                else
                    Console.WriteLine(args[i] + ", " + palindromToCheck + " - Is a palindrome");

                Console.ReadLine();
            }
        }
    }
}