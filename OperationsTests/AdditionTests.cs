using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 15;
        private readonly int b = 3;
        private readonly double c = 7.6;
        private readonly double d = 3.2;
        private readonly double[] e = { 6.02, 1.3, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(18, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            Assert.AreEqual(10.8, Addition.Sum(c, d));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(9.82, Addition.Sum(e));
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(40, Addition.Sum(f));
        }
    }
}