using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Count_and_Say_38
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";
            var countSay = "1";
            for (var i = 2; i <= n; i++)
            {
                var count = 1;
                var num = countSay[0];
                var temp = countSay;
                countSay = "";
                for (var a = 1; a < temp.Length; a++)
                {
                    if (temp[a] == num)
                    {
                        count++;
                    }
                    else
                    {
                        countSay += count;
                        countSay += num;
                        num = temp[a];
                        count = 1;
                    }
                }
                countSay += count;
                countSay += num;
            }
            return countSay;
        }
    }
}
