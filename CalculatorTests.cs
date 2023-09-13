using NUnit.Framework;

namespace WatiTest
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(2,3,5)]
        [TestCase(0,0,0)]
        [TestCase(2, 3, 4)]
        [TestCase(10, -5, 5)]
        public void TestAddition(int num1, int num2, int expectedSum)
        {
            int result = num1 + num2;
            Assert.AreEqual(expectedSum, result);
        }
    }
}
