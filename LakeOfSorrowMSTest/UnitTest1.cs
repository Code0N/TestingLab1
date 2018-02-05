using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LakeOfSorrowProduction;

namespace LakeOfSorrowMSTest
{
    [TestClass]
    public class LOSUnitTest
    {
        // ARRANGE
        readonly StringFormatter stringFormatter = new StringFormatter();

        [TestMethod]
        public void TestString()
        {
            // ACT
            string res = stringFormatter.ShortFileString("C:\\Users\\Useless File.txt");

            // ASSERT
            Assert.AreEqual("USELESS FILE.TMP", res);
        }

        [TestMethod]
        public void TestEmptyString()
        {
            // ACT
            string res = stringFormatter.ShortFileString(String.Empty);

            // ASSERT
            Assert.AreEqual(String.Empty, res);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestExept()
        {
            stringFormatter.ShortFileString(null);
        }
    }
}
