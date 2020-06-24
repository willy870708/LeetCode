using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Count_and_Say_Test
    {
        [Test]
        public void count_and_say()
        {
            var count = new Count_and_Say_38();
            var expected = count.CountAndSay(4);
            Assert.AreEqual(expected, "1211");
        }
    }
}
