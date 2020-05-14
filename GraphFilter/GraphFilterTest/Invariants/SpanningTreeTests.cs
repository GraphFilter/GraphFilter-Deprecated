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
    public class SpanningTreeTests
    {

        Graph h = GraphHelper.ExBronKerb_Wiki();
        Graph g = GraphHelper.Complete(6);
        Graph r = GraphHelper.wheel_5();
        [TestMethod()]
        public void NumberSpanningTreeTest()
        {
            Assert.AreEqual(11, Invariant.NumberSpanningTree.Calculate(h));
            Assert.AreEqual(1296, Invariant.NumberSpanningTree.Calculate(g));
            Assert.AreEqual(121, Invariant.NumberSpanningTree.Calculate(r));
        }
    }
}