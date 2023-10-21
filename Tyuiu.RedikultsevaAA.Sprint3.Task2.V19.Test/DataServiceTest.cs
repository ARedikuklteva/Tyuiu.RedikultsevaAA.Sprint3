using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint3.Task2.V19.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = -0.709;
            double wait = ds.GetSumSeries(startValue, stopValue);

            Assert.AreEqual(res, wait);
        }
    }
}
