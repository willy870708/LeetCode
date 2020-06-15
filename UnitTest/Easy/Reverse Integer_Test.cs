using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using NUnit.Framework;

namespace UnitTest
{
    class Reverse_Integer_Test
    {
        [Test]
        public void Reverse_integer_test()
        {
            var reverse_integer = new Reverse_Integer_7();
            var expected = reverse_integer.Reverse(123456);
            Assert.AreEqual(expected, 654321); 
        }
    }
}
