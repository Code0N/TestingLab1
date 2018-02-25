using System;
using System.Linq;
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
        public void TestUpperCase()
        {
            /*
                                              _       _     
                                | |     | |    
                  ___ _ __ _   _| |_ ___| |__  
                 / __| '__| | | | __/ __| '_ \ 
                | (__| |  | |_| | || (__| | | |
                 \___|_|   \__,_|\__\___|_| |_|
                               
                               
             */

            // ACT
            string res = stringFormatter.ShortFileString("C:\\Users\\UselessFile.txt");

            // ASSERT
            Assert.AreEqual(14, res.Count(Char.IsUpper));
        }

        [TestMethod]
        public void TestFinalString()
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
        public void TestExeption()
        {
            stringFormatter.ShortFileString(null);
        }
    }
}
