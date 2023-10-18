using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint3.Task0.V9.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint3.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int StartValue = 1;
            int StopValue = 15;

            double res = ds.GetSumSeries(value, StartValue, StopValue);

            double wait = 0.286;

            Assert.AreEqual(wait, res);
        }
    }
}
