using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Length_of_Last_Word_Test
    {
        [Test]
        public void length_of_last_word()
        {
            var length = new Length_of_Last_Word_58();
            var expected = length.LengthOfLastWord("b   a    ");
            Assert.AreEqual(expected, 1);
        }
    }
}
