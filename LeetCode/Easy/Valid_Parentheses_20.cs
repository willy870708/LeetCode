using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Valid_Parentheses_20
    {
        public bool IsValid(string s)
        {
            var temp = new Stack();
            if (s.Length == 1) return false;
            if (s.Length == 0) return true;
            temp.Push(s[0]);
            var dictionary = new Dictionary<char, char>()
            {
                {'(',')' },
                {'{','}' },
                {'[',']' },
                {')','(' },
                {']','[' },
                {'}','{' },
            };
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == dictionary.Keys.ToList()[0]
                        || s[i] == dictionary.Keys.ToList()[1]
                        || s[i] == dictionary.Keys.ToList()[2])
                {
                    temp.Push(s[i]);
                }
                else if(temp.Count == 0)
                {
                    temp.Push(s[i]);
                }
                else if(s[i] != dictionary[Convert.ToChar(temp.Peek())])
                {
                    return false;
                }
                if (s[i] == dictionary[Convert.ToChar(temp.Peek())])
                {
                    temp.Pop();
                }
            }
            if(temp.Count!=0)return false;
            return true;
        }
    }
}
