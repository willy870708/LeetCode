﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Remove_Duplicates_from_Sorted_Array_26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for(int j = 1; j < nums.Length; j++)
            {
                if(nums[i] != nums[j])
                {
                    i++;
                }
            }
            return i + 1;
        }
    }
}
