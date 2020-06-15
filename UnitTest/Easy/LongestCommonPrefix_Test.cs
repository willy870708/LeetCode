using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using NUnit.Framework;

namespace UnitTest
{
    class LongestCommonPrefix_Test
    {
        [Test]
        public void get_LongestCommonPrefix()
        {
            var longestCommonPrefix = new LongestCommonPrefix14();
            var expected = longestCommonPrefix.LongestCommonPrefix(new string[] {"flower","floor","flower","flat"});
            Assert.AreEqual(expected,"fl");
        }
    }
}
