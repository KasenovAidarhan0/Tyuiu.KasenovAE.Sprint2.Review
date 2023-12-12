using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.TaskReview.V4.Lib;

namespace Tyuiu.KasenovAE.Sprint2.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            var ds = new DataService();
            bool w = false;
            bool r = ds.InGraph(0.1, 0.1);
            Assert.AreEqual(w, r);
        }
    }
}
