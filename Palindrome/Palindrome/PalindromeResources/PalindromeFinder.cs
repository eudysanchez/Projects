using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Reference: https://miafish.wordpress.com/2015/01/23/leetcode-oj-c-longest-palindromic-substring/
namespace PalindromeResources
{
    public class PalindromeFinder : IPalindromeFinder
    {
        public PalindromeFinder(){ }

        public string FindLargestPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return String.Empty;
            var result = string.Empty;
            var reslen = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var p1 = expandAroundCenter(input, i, i);
                if (p1.Length > reslen)
                {
                    reslen = p1.Length;
                    result = p1;
                }

                var p2 = expandAroundCenter(input, i, i + 1);
                if (p2.Length > reslen)
                {
                    reslen = p2.Length;
                    result = p2;
                }
            }

            return result;
        }

        private string expandAroundCenter(string s, int i, int j)
        {
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                i--;
                j++;
            }

            return s.Substring(i + 1, j - i - 1);
        }
    }
}
