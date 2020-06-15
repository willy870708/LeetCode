using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Palindrome_Number_9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;
            var reverse = 0;
            var pop = 0;
            var original = x;
            while (x != 0)
            {
                pop = x % 10;
                x /= 10;
                reverse = reverse * 10 + pop;
            }
            if (reverse == original) return true;
            return false;
        }
    }
}
