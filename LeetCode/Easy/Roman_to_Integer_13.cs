using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Roman_to_Integer_13
    {
        public int RomanToInt(string s)
        {
            var mapping = new Dictionary<char, int>() {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000},
            };
            var ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i != s.Length - 1)
                {
                    if (s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                    {
                        ans -= 2;
                    }
                    else if (s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                    {
                        ans -= 20;
                    }
                    else if (s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                    {
                        ans -= 200;
                    }
                }
                ans += mapping[s[i]];
            }
            return ans;
        }
    }
}
