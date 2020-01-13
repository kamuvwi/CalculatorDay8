using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 15;
        private readonly int b = 3;
        private readonly double c = 7.5;
        private readonly double d = 3.4;
        private readonly double[] e = { 6.02, 1.3, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(12, Subtraction.Difference(a, b));
        }

        [TestMethod()]
        public void DifferenceDoubleTest()
        {
            Assert.AreEqual(4.1, Subtraction.Difference(c, d));
        }

        [TestMethod()]
        public void DifferenceDoubleArrayTest()
        {
            Assert.AreEqual(-9.82, Subtraction.Difference(e));
        }

        [TestMethod()]
        public void DifferenceIntArrayTest()
        {
            Assert.AreEqual(-40, Subtraction.Difference(f));
        }
    }
}