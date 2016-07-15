using PalindromeResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            IPalindromeFinder palindrome = new PalindromeFinder();

            Console.WriteLine("Enter Palindrome");
            var input = Console.ReadLine();

            var result = palindrome.FindLargestPalindrome(input);

            Console.WriteLine("This is the Longest Palindrome: " + result);

            Console.ReadKey();
        }
    }
}
