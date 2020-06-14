using LeetCode;
using NUnit.Framework;
namespace UnitTest
{
    class Two_Sum_Test
    {
        [Test]
        public void Two_Sum()
        {
            var twoSum = new Two_Sum_1();
            var excepted = twoSum.TwoSum(new int[] { 1, 5, 3, 4 }, 5);
            Assert.AreEqual(new int[] { 0, 3 }, excepted);
        }
    }
}
