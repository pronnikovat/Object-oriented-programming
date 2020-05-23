using Lesson_7;
using NUnit.Framework;

namespace UnitTests
{
    public class UnitTest
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { -10, -15, -25, -30, -35 }, -23)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 1)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 1, -2, 3, 1, 3 }, 1.2)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2.5)]
        [TestCase(new int[] { -1, -2, -3, -4, -5, -6 }, -3.5)]
        [TestCase(new int[] { 90, 90, 80, 85 }, 86.25)]
        [TestCase(new int[] { 40, -60, 80 }, 20)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 1.5)]

        public void Task1Test(int[] a, double expectedResult)
        {
            Assert.AreEqual(expectedResult, Program.myDelegate1.Invoke(a));
        }

        [TestCase(0, 0, "+", ExpectedResult = 0)]
        [TestCase(1, 1, "-", ExpectedResult = 0)]
        [TestCase(1, 1, "+", ExpectedResult = 2)]
        [TestCase(1, 2, "-", ExpectedResult = -1)]
        [TestCase(1, 2, "+", ExpectedResult = 3)]
        [TestCase(14, 15, "-", ExpectedResult = -1)]
        [TestCase(14, 15, "+", ExpectedResult = 29)]
        [TestCase(-2400, -1500, "-", ExpectedResult = -900)]
        [TestCase(-2400, -1500, "+", ExpectedResult = -3900)]
        [TestCase(2, 3, "*", ExpectedResult = int.MinValue + 1)]

        public int Task2Test(int x, int y,string oper)
        {
            return Program.myDelegate2.Invoke(x, y, oper);
        }
    }
}
