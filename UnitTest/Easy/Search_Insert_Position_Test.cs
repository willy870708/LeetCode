using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Search_Insert_Position_Test
    {
        [Test]
        public void search_insert_position()
        {
            var search = new Search_Insert_Position_35();
            var expected = search.SearchInsert(new int[] { 1, 3, 5, 6 },4);
            Assert.AreEqual(expected, 2);
        }
    }
}
