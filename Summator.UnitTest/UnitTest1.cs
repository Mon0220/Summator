using NUnit.Framework;

namespace Summator.UnitTest
{
    public class SummatoTests
    {
        [Test]
        public void Test_SummatorTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_SummatorTwoNegativNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.sum(nums);

            var expected = -100;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SummatorOnePositivANdOneNegavitNumbers()
        {
            var nums = new int[] { -1, 5 };
            var actual = Summator.sum(nums);

            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SummatorOneNumbers()
        {
            var nums = new int[] { 5 };
            var actual = Summator.sum(nums);

            var expected = 5;

            Assert.AreEqual(expected, actual);
        }
    }
}