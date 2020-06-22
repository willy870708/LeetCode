using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Search_Insert_Position_35
    {
        public int SearchInsert(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] >= target)
                {
                    return i;
                }
                else if(i == nums.Length - 1)
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
}
