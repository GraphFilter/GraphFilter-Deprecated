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
            Assert.AreEqual(5, Invariant.MaxDegree.Calculate(wheel_6));
        }

        [TestMethod()]
        public void MinTest()
        {
            Assert.AreEqual(3, Invariant.MinDegree.Calculate(wheel_6));
        }

        [TestMethod()]
        public void AverageTest()
        {
            Assert.IsTrue(Invariant.AverageDegree.Calculate(wheel_6) > 3.33 && Invariant.AverageDegree.Calculate(wheel_6) < 3.34);
        }

        [TestMethod()]
        public void IsRegularTest()
        {
            Assert.IsFalse(Invariant.IsRegular.Calculate(wheel_6));
            Assert.IsTrue(Invariant.IsRegular.Calculate(GraphHelper.Complete(5)));
        }

        [TestMethod()]
        public void IsRegularWithDegreeTest()
        {
            Assert.IsFalse(Invariant.IsRegularWithDegree.Calculate(wheel_6, 3));
            Assert.IsTrue(Invariant.IsRegularWithDegree.Calculate(GraphHelper.Complete(5), 4));
            Assert.IsFalse(Invariant.IsRegularWithDegree.Calculate(GraphHelper.Complete(5), 5));
        }
    }
}