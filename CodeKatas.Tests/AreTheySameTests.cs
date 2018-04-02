using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatas.Tests
{
    [TestClass]
    public class AreTheySameTests
    {
        [TestMethod]
        public void TestMultiplicities()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.Comp(a, b);
            Assert.AreEqual(true, r);
        }
    }
}
