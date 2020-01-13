using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations.Tests
{
    [TestClass()]
    public class SqRtTests
    {
        private readonly int a = 225;
        private readonly double c = 57.76;
        private readonly double[] e = { 6.2, 1.5, 2.5 };
        private readonly int[] f = { 30, 3, 2, 5 };

        [TestMethod()]
        public void RootTest()
        {
            Assert.AreEqual(15, SqRt.Root(a));
        }

        [TestMethod()]
        public void RootDoubleTest()
        {
            Assert.AreEqual(7.6, SqRt.Root(c));
        }

        [TestMethod()]
        public void RootDoubleArrayTest()
        {
            double[] x = new double[e.Length];
            double[] y = SqRt.Root(e);
            int i = 0;
            foreach (double a in e)
            {
                x[i] = SqRt.Root(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }

        [TestMethod()]
        public void RootIntArrayTest()
        {
            double[] x = new double[f.Length];
            double[] y = SqRt.Root(f);
            int i = 0;
            foreach (int a in f)
            {
                x[i] = SqRt.Root(a);
                Assert.AreEqual(x[i], y[i]);
                i++;
            }
        }
    }
}