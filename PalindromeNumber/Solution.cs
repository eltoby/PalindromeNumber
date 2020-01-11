using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {

            if (x < 0)
                return false;

            if (x == 0)
                return true;

            if (x % 10 == 0)
                return false;

            var part = x;
            var reversed = 0;

            while (part > 0)
            {
                reversed = reversed * 10 + part % 10;
                part /= 10;
            }

            return reversed == x;
        }
    }
}
