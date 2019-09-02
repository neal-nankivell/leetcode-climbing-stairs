using Answer;
using NUnit.Framework;

namespace Tests
{
    public class SolutionTests
    {
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 3)]
        public int ClimbStairs(int n)
        {
            var sut = new Solution();
            return sut.ClimbStairs(n);
        }
    }
}