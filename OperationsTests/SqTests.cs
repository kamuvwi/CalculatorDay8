using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations.Tests
{
    [TestClass()]
    public class SqTests
    {
        private readonly int a = 15;
        private readonly double c = 7.6;
        private readonly double[] e = { 6.2, 1.5, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(225, Sq.Squared(a));
        }

        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(57.76, Sq.Squared(c));
        }

        [TestMethod()]
        public void SquaredDoubleArrayTest()
        {
            double[] x = new double[e.Length];
            double[] y = Sq.Squared(e);
            int i = 0;
            foreach (double a in e)
            {
                x[i] = Sq.Squared(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        [TestMethod()]
        public void SquaredIntArrayTest()
        {
            int[] x = new int[f.Length];
            int[] y = Sq.Squared(f);
            int i = 0;
            foreach (int a in f)
            {
                x[i] = Sq.Squared(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }
    }
}