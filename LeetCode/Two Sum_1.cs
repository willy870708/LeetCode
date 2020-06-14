using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Two_Sum_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var ans = new int[2];
            var temp = nums.ToList();
            for (int i = 0; i < temp.Count - 1; i++)
            {
                for (int j = i+1; j < temp.Count; j++)
                {
                    if (target - temp[i] == temp[j])
                    {
                        ans = new int[2] { i, j };
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
