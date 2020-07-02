using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Plus_One_66
    {
        public int[] PlusOne(int[] digits)
        {
            int carry = 0;
            if (digits.Last() == 9)
            {
                digits[digits.Count() - 1] = 0;
                carry++;
            }
            else
            {
                digits[digits.Count() - 1] += 1;
            }
            for (int i = digits.Count() - 2; i >= 0; i--)
            {
                if (carry == 1)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] += 1;
                        carry--;
                    }
                }
            }
            if(carry == 1)
            {
                var ans = new int[digits.Count() + 1];
                new int[] { 1 }.CopyTo(ans, 0);
                digits.CopyTo(ans, 1);
                return ans;
            }
            return digits;
        }
    }
}
