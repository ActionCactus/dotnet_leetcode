using System;
using Xunit;
using leetcode;

namespace leetcode.test
{
    public class TwoSumTest
    {
        [Fact]
        public void TestSimpleExecution()
        {
            int[] result = TwoSum.calc(new int[] { 1, 2, 3 }, 5);
            Assert.Contains(1, result);
            Assert.Contains(2, result);
        }

        [Fact]
        public void TestExecutionWithNoResults()
        {
            Assert.Null(TwoSum.calc(new int[] { 1, 2, 3 }, 172));
        }
    }
}
