using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint3.Task3.V14.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint3.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();

            string value = "dgt ghedd bed";
            char replacebale = 'd';
            char replacement = '’';

            string res = ds.ReplaceCharInString(value, replacebale, replacement);

            string wait = "’gt ghe’’ be’";

            Assert.AreEqual(res, wait);
        }
    }
}