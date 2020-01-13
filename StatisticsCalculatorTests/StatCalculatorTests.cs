﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatCalculatorTests
    {
        private readonly StatCalculator statCalc = new StatCalculator();
        private readonly int[] values = { 1, 2, 3, 4, 5 };
        private readonly int score = 4;
        private readonly double[] doubleVal = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        private readonly double doubleScore = 2.2;

        [TestMethod()]
        public void MeanIntTest()
        {
            var mean = statCalc.Mean(values);
            Assert.AreEqual(3, mean);
        }

        [TestMethod()]
        public void VarianceIntTest()
        {
            var variance = statCalc.Variance(values);
            Assert.AreEqual(2, Helpers.Rounding.RoundFiveDecimals(variance));
        }

        [TestMethod()]
        public void StandDevIntTest()
        {
            var standDev = statCalc.StandDev(values);
            Assert.AreEqual(1.41421, Helpers.Rounding.RoundFiveDecimals(standDev));
        }

        [TestMethod()]
        public void ZScoreIntTest()
        {
            var z = statCalc.ZScore(score, values);
            Assert.AreEqual(0.70711, Helpers.Rounding.RoundFiveDecimals(z));
        }

        [TestMethod()]
        public void MeanDoubleTest()
        {
            var mean = statCalc.Mean(doubleVal);
            Assert.AreEqual(3.3, mean);
        }

        [TestMethod()]
        public void VarianceDoubleTest()
        {
            var variance = statCalc.Variance(doubleVal);
            Assert.AreEqual(2.09, Helpers.Rounding.RoundFiveDecimals(variance));
        }

        [TestMethod()]
        public void StandDevDoubleTest()
        {
            var standDev = statCalc.StandDev(doubleVal);
            Assert.AreEqual(1.44568, Helpers.Rounding.RoundFiveDecimals(standDev));
        }

        [TestMethod()]
        public void ZScoreDoubleTest()
        {
            var z = statCalc.ZScore(doubleScore, doubleVal);
            Assert.AreEqual(-0.76089, Helpers.Rounding.RoundFiveDecimals(z));
        }
    }
}