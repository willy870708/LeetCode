using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Maximum_Subarray_53
    {
        public int MaxSubArray(int[] nums)
        {
            var ans = nums[0];
            var currentMax = nums[0];
            for(int i = 1; i<nums.Length; i++)
            {
                currentMax += nums[i];
                if(currentMax < nums[i] || currentMax < 0)
                {
                    currentMax = nums[i];
                }
                if(ans < currentMax)
                {
                    ans = currentMax;
                }
            }
            return ans;
        }
    }
}
