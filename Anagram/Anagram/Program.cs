using Anagram.AnagramChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First word");
            var input1 =  Console.ReadLine();

            Console.WriteLine("Enter Second word");
            var input2 = Console.ReadLine();

            string result;
            IAnagramCheck check = new AnagramCheck();

            if (check.IsAnagram(input1, input2))
            {
                result = "Are Anagrams";
            }
            else
                result = "Are Not Anagrams";

            Console.WriteLine(input1 + " " + input2 + " " + result);

            Console.ReadKey();
        }
    }
}
