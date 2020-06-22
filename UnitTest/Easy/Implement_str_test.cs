using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Implement_str_test
    {
        [Test]
        public void implement_str__succes_test()
        {
            var implement = new Implement_strStr_28();
            var expected = implement.StrStr("mississippi", "sippia");
            Assert.AreEqual(expected, 1);
        }
        [Test]
        public void implement_str__fail_test()
        {
            var implement = new Implement_strStr_28();
            var expected = implement.StrStr("aaaaaaaa", "bba");
            Assert.AreEqual(expected, -1);
        }
    }
}
