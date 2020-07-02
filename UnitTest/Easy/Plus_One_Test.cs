using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Plus_One_Test
    {
        [Test]
        public void plus_one_test()
        {
            var plus = new Plus_One_66();
            var expected = plus.PlusOne(new int[] { 9 });
            Assert.AreEqual(expected, new int[] { 1,0 });
        }
    }
}
