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
        Graph wheel_6 = GraphHelper.Wheel_6();

        [TestMethod()]
        public void MaxTest()
        {
            Assert.AreEqual(5, Degree.Max(wheel_6));
        }

        [TestMethod()]
        public void MinTest()
        {
            Assert.AreEqual(3, Degree.Min(wheel_6));
        }

        [TestMethod()]
        public void AverageTest()
        {
            Assert.IsTrue(Degree.Average(wheel_6) > 3.33 && Degree.Average(wheel_6) < 3.34);
        }

        [TestMethod()]
        public void IsRegularTest()
        {
            Assert.IsFalse(Degree.IsRegular(wheel_6));
            Assert.IsTrue(Degree.IsRegular(GraphHelper.Complete(5)));
        }

        [TestMethod()]
        public void IsRegularWithDegreeTest()
        {
            Assert.IsFalse(Degree.IsRegularWithDegree(wheel_6, 3));
            Assert.IsTrue(Degree.IsRegularWithDegree(GraphHelper.Complete(5), 4));
            Assert.IsFalse(Degree.IsRegularWithDegree(GraphHelper.Complete(5), 5));
        }
    }
}