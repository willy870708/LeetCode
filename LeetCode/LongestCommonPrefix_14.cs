using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestCommonPrefix14
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var ans = "";
            int? min = strs.Min(x => x.Length);
            for (int i = 0; i < min; i++)
            {
                var first = strs[0][i];
                if (strs.All(x => x[i] == first))
                {
                    ans += first;
                }
                else
                {
                    break;
                }
            }
            return ans;
        }
    }
}
