using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int età = 21;

            int battitofiero = 199;

            int aspettativa=CardioLibrary.DataCardio.Battiti(età);

            Assert.AreEqual(battitofiero, aspettativa);

        }
    }
}
