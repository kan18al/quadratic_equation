using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using quadratic_equation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace UnitQuadEqua
{
    [TestFixture]
    public class Class1
    {
        private parabola para = null;
        [SetUp]
        public void init()
        {
            para = new parabola(5, 5, 5);
        }
        [Test]
        public void TestDiscriminant()
        {
            para.discriminant();
            double actualPar = para.D;
            Assert.AreEqual(-75, actualPar);
        }

        [Test]
        public void TestRoot_one()
        {
            para.root_one();
            double actualRoot_one = para.X1;
            Assert.AreEqual(-12.5, actualRoot_one);
        }

        [Test]
        public void TestRoot_two()
        {
            para.root_two();
            double actualRoot_one = para.X1;
            double actualRoot_two = para.X2;
            Assert.AreEqual(-12.5, actualRoot_one);
            Assert.AreEqual(-12.5, actualRoot_two);
        }
    }
}
