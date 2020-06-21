using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Remove_Duplicates_from_Sorted_Array_Test
    {
        [Test]
        public void remove_duplicates_test()
        {
            var remove_duplicate = new Remove_Duplicates_from_Sorted_Array_26();
            var expected = remove_duplicate.RemoveDuplicates(new int[] {1, 1, 2});
            Assert.AreEqual(expected, 2);
        }
    }
}
