using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Remove_Element_Test
    {
        [Test]
        public void remove_Element_Test()
        {
            var remove = new Remove_Element_27();
            var expected = remove.RemoveElement(new int[] { 3, 2, 2, 3 },3);
            Assert.AreEqual(expected, 3);
        }
    }
}
