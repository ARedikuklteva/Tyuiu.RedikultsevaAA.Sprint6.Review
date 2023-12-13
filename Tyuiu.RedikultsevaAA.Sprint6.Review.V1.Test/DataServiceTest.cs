using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint6.Review.V1.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Review.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Result()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[3, 3]  { {0, 3, 6},
                                           {1, 4, 5},
                                           {1, 4, 7 }};

            int res = ds.Result(mas2, 0, 2, 1);

            int wait = 11;
            Assert.AreEqual(res, wait);
        }
    }
}
