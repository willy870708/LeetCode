using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Valid_Parentheses_Test
    {
        [Test]
        public void valid_parentheses_pass_test()
        {
            var valid_parentheses = new Valid_Parentheses_20();
            var isValid = valid_parentheses.IsValid("{()}");
            Assert.IsTrue(isValid);
        }
        [Test]
        public void valid_parentheses_fail_test()
        {
            var valid_parentheses = new Valid_Parentheses_20();
            var isValid = valid_parentheses.IsValid("[])");
            Assert.IsFalse(isValid);
        }
    }
}
