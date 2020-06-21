using FluentAssertions;
using LeetCode.Easy;
using NUnit.Framework;

namespace UnitTest.Easy
{
    class Merge_Two_Sorted_Lists_Test
    {
        [Test]
        public void When_Merge_Two_Sorted_Lists_()
        {
            var merge = new Merge_Two_Sorted_Lists_21();
            var expected = merge.MergeTwoLists(new ListNode() {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 4,
                        next = null
                    }
                }
            }, new ListNode() {
                val = 1,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 4,
                        next = null
                    }
                }
            });
            expected.Should().BeEquivalentTo(new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 1,
                    next = new ListNode()
                    {
                        val = 2,
                        next = new ListNode()
                        {
                            val = 3,
                            next = new ListNode()
                            {
                                val = 4,
                                next = new ListNode()
                                {
                                    val = 4,
                                    next = null
                                }
                            }
                        }
                    }
                }
            });
            }
    }
}
