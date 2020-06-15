using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoSum = new Two_Sum_1();
            twoSum.TwoSum(new int[] { 1, 5, 3, 4 }, 5);
            var reverse = new Reverse_Integer_7();
            reverse.Reverse(1534236469);

            var palindrome_number = new Palindrome_Number_9();
            var isvalid = palindrome_number.IsPalindrome(12321);
            var a = "";
        }
    }
}
