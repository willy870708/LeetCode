using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode;
using NUnit.Framework;

namespace UnitTest
{
    class Palindrome_Number_Test
    {
        [Test]
        public void Palindrome_Number_isFalse()
        {
            var palindrome_number = new Palindrome_Number_9();
            var isvalid = palindrome_number.IsPalindrome(-123210);
            Assert.IsFalse(isvalid);
        }

        [Test]
        public void Palindrome_Number_isTrue()
        {
            var palindrome_number = new Palindrome_Number_9();
            var isvalid = palindrome_number.IsPalindrome(12321);
            Assert.IsTrue(isvalid);
        }
    }
}
