using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 15;
        private readonly int b = 3;
        private readonly double c = 7.6;
        private readonly double d = 3.2;
        private readonly double[] e = { 6.2, 1.5, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void TimesTest()
        {
            Assert.AreEqual(45, Multiplication.Times(a, b));
        }

        [TestMethod()]
        public void TimesDoubleTest()
        {
            Assert.AreEqual(24.32, Multiplication.Times(c, d));
        }

        [TestMethod()]
        public void TimesDoubleArrayTest()
        {
            Assert.AreEqual(23.25, Multiplication.Times(e));
        }

        [TestMethod()]
        public void TimesIntArrayTest()
        {
            Assert.AreEqual(900, Multiplication.Times(f));
        }
    }
}