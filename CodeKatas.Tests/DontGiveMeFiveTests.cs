using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatas.Tests
{
    [TestClass]
    class DontGiveMeFiveTests
    {
        [TestMethod]
        public void TestNoFives()
        {
            Assert.AreEqual(8, DontGiveMeFive.NoFives(1, 9));
            Assert.AreEqual(12, DontGiveMeFive.NoFives(4, 17));
        }
    }
}