using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Roman_to_Integer_Test
    {
        [Test]
        public void roman_to_integer()
        {
            var romanToIneger = new Roman_to_Integer_13();
            var expected = romanToIneger.RomanToInt("MCMXCIV");
            Assert.AreEqual(expected, 1994);
        }
    }
}
