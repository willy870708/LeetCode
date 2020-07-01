using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Length_of_Last_Word_58
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            var temp = s.Split(' ');
            for (int i = 0; i < temp.Length; i++)
            {
                if(temp.Last().Length == 0)
                {
                    temp = temp.Where(val => val != temp.Last()).ToArray();
                }
                else
                {
                    return temp.Last().Length;
                }
            }
            if (temp.Length == 0) return 0;
            return temp.Last().Length;
        }
    }
}
