using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LakeOfSorrowProduction;

namespace LakeOfSorrowNUnitTests
{
    [TestFixture]
    public class TestClass
    {
        readonly Rectangle rectangle = new Rectangle();
        [Test]
        public void TestVertices1()
        {
            double[] x = { -2, 6, 6, 3 };
            double[] y = { 4, 4, -2, -3 };
            rectangle.SetVertices(x, y);
            double res = rectangle.Diagonal();
            Assert.AreEqual(10, res);
        }

        [Test]
        public void TestVertices2()
        {
            double[] x = { -2, -2, 4, 4 };
            double[] y = { -3, 5, 5, -5 };
            rectangle.SetVertices(x, y);
            double res = rectangle.Diagonal();
            Assert.AreEqual(10, res);
        }

        [Test]
        public void ExeptionTest1()
        {
            double[] x = { 10, 20, 30, 40 };
            double[] y = { 50, 60, 70, 80 };
            //rectangle.SetVertices(x, y);
            Assert.Throws<ArgumentException>(() => rectangle.SetVertices(x, y));
        }
    }
}
