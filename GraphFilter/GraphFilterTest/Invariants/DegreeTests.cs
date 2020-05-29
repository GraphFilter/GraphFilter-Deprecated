using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphFilterTest.GraphHelper;

namespace GraphFilter.Invariants.Tests
{
    [TestClass()]
    public class DegreeTests
    {
        Graph wheel_6 = GraphHelper.wheel_5();

        [TestMethod()]
        public void MaxTest()
        {
            Assert.AreEqual(5, InvariantNum.MaxDegree.Calculate(wheel_6));
        }

        [TestMethod()]
        public void MinTest()
        {
            Assert.AreEqual(3, InvariantNum.MinDegree.Calculate(wheel_6));
        }

        [TestMethod()]
        public void AverageTest()
        {
            Assert.IsTrue(InvariantNum.AverageDegree.Calculate(wheel_6) > 3.33 && InvariantNum.AverageDegree.Calculate(wheel_6) < 3.34);
        }

        [TestMethod()]
        public void IsRegularTest()
        {
            Assert.IsFalse(InvariantBool.IsRegular.Calculate(wheel_6));
            Assert.IsTrue(InvariantBool.IsRegular.Calculate(GraphHelper.Complete(5)));
        }

        [TestMethod()]
        public void IsRegularWithDegreeTest()
        {
            Assert.IsFalse(InvariantBool.IsRegularWithDegree.Calculate(wheel_6, 3));
            Assert.IsTrue(InvariantBool.IsRegularWithDegree.Calculate(GraphHelper.Complete(5), 4));
            Assert.IsFalse(InvariantBool.IsRegularWithDegree.Calculate(GraphHelper.Complete(5), 5));
        }
    }
}