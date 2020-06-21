using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Remove_Element_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            var ans = nums.Length;
            for (int i = 0; i < ans; i++)
            {
                if(nums[i] == val)
                {
                    nums[i] = nums[ans-1];
                    ans--;
                }
            }
                return ans;
        }
    }
}
