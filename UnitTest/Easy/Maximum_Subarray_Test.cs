using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Maximum_Subarray_Test
    {
        [Test]
        public void maximum_subarray_test()
        {
            var max = new Maximum_Subarray_53();
            var expected = max.MaxSubArray(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.AreEqual(expected, 6);
        }
    }
}
