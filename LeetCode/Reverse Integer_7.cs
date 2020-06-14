using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Reverse_Integer_7
    {
        public int Reverse(int x)
        {
            var ans = 0;
            while(x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (ans > int.MaxValue/ 10 || (ans == int.MaxValue / 10 && pop > 7)) return 0;
                if (ans < int.MinValue / 10 || (ans == int.MinValue / 10 && pop < -8)) return 0;
                ans = ans * 10 + pop;                
            }  
            return ans;
        }
    }
}
