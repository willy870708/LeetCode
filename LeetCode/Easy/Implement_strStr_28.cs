namespace LeetCode.Easy
{
    public class Implement_strStr_28
    {
        public int StrStr(string haystack, string needle)
        {
            var i = 0;
            var ans = 0;
            var state = false;
            if (needle.Length > haystack.Length) return -1;
            if ((haystack.Length == 0 && needle.Length == 0) || needle.Length == 0) return 0;
            for (i = 0; i < haystack.Length; i++)
            {
                if (ans == needle.Length)
                {
                    break;
                }
                if (i + needle.Length > haystack.Length) return -1;
                if (haystack[i] == needle[0])
                {
                    if (haystack.Substring(i, needle.Length) == needle)
                    {
                        return i;
                    }
                }
            }
            if (state == false)
            {
                return -1;
            }
            return ans;
        }
    }
}
