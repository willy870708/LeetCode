using LeetCode.Easy;

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


            var romanToIneger = new Roman_to_Integer_13();
            var ans = romanToIneger.RomanToInt("MCMXCIV");
            var x = "abcde";
            var a = x.ToCharArray();
            for (int i = 0; i < x.Length / 2; i++)
            {
                a[i] = x[x.Length - i - 1];
                a[x.Length - i - 1] = x[i];
            }
        }
    }
}
