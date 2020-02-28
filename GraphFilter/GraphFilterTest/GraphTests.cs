using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphFilterTest.GraphHelper;

namespace GraphFilter.Tests
{
    [TestClass()]
    public class GraphTests
    {
        Graph wheel6 = GraphHelper.Wheel_6();
        
        [TestMethod()]
        public void adjacentTest()
        {
            Assert.IsTrue(wheel6.adjacent(0, 1));
            Assert.IsFalse(wheel6.adjacent(1, 3));
        }

        [TestMethod()]
        public void NTest()
        {
            List<int> neighbourhood = wheel6.N(1);
            Assert.IsTrue(neighbourhood.Contains(0));
            Assert.IsFalse(neighbourhood.Contains(1));
            Assert.IsTrue(neighbourhood.Contains(2));
            Assert.IsFalse(neighbourhood.Contains(3));
            Assert.IsFalse(neighbourhood.Contains(4));
            Assert.IsTrue(neighbourhood.Contains(5));
            Assert.IsFalse(neighbourhood.Contains(6));
        }

        [TestMethod()]
        public void DegreeOfTest()
        {
            for (int i = 1; i < 6; i++) Assert.AreEqual(wheel6.DegreeOf(i), 3);
            Assert.AreEqual(5, wheel6.DegreeOf(0));
        }

        [TestMethod()]
        public void SequenceDegreeTest()
        {
            List<int> seqDegree = wheel6.SequenceDegree();
            Assert.AreEqual(seqDegree[0], 5);
            for (int i = 1; i < 6; i++) Assert.AreEqual(wheel6.DegreeOf(i), 3);

        }
    }
}