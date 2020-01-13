using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 15;
        private readonly int b = 3;
        private readonly double c = 6.8;
        private readonly double d = 3.4;
        private readonly double[] e = { 23.25, 2.5, 6.2 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void QuotientTest()
        {
            Assert.AreEqual(5, Division.Quotient(a, b));
        }

        [TestMethod()]
        public void QuotientDoubleTest()
        {
            Assert.AreEqual(2, Division.Quotient(c, d));
        }

        [TestMethod()]
        public void QuotientDoubleArrayTest()
        {
            Assert.AreEqual(1.5, Division.Quotient(e));
        }

        [TestMethod()]
        public void QuotientIntArrayTest()
        {
            Assert.AreEqual(1, Division.Quotient(f));
        }
    }
}