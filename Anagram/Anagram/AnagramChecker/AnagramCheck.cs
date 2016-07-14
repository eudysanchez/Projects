
namespace Anagram.AnagramChecker
{
    public class AnagramCheck : IAnagramCheck
    {
        public AnagramCheck() { }

        public bool IsAnagram(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return false;
            if (s1.Length != s2.Length)
                return false;

            foreach (char c in s2)
            {
                int indexOfLetter = s1.IndexOf(c);
                if (indexOfLetter  >= 0)
                    s1 = s1.Remove(indexOfLetter, 1);
                else
                    return false;
            }

            return string.IsNullOrEmpty(s1);
        }
    }
}
