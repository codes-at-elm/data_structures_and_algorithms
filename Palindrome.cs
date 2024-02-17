using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal static class Palindrome
    {
        public static bool IsPalindrome(string str)
        {
            str = str.ToLower();
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                if (!str[i].Equals(str[j]))
                    return false;
            }

            return true;
        }
    }
}
