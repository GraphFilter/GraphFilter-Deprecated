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
    public class CliqueTests
    {
        Graph g = GraphHelper.ExBronKerb_Wiki();
        Graph h = GraphHelper.Complete(5);
        [TestMethod()]
        public void CliqueNumberTest()
        {
            
            Assert.AreEqual(5, CliqueNumber.Calculate(h));
            Assert.AreEqual(3, CliqueNumber.Calculate(g));
        }

        [TestMethod()]
        public void IndependenceNumberTest()
        {
            Assert.AreEqual(3, IndependenceNumber.Calculate(g));
            Assert.AreEqual(1, IndependenceNumber.Calculate(h));
        }
    }
}