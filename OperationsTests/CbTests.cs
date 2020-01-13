using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations.Tests
{
    [TestClass()]
    public class CbTests
    {
        private readonly int a = 15;
        private readonly double c = 7.5;
        private readonly double[] e = { 6.2, 1.5, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(3375, Cb.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(421.875, Cb.Cubed(c));
        }

        [TestMethod()]
        public void CubedDoubleArrayTest()
        {
            double[] x = new double[e.Length];
            double[] y = Cb.Cubed(e);
            int i = 0;
            foreach (double a in e)
            {
                x[i] = Cb.Cubed(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        [TestMethod()]
        public void CubedIntArrayTest()
        {
            int[] x = new int[f.Length];
            int[] y = Cb.Cubed(f);
            int i = 0;
            foreach (int a in f)
            {
                x[i] = Cb.Cubed(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }
    }
}