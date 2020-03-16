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
        [TestMethod()]
        public void CliqueNumberTest()
        {
            Graph g = GraphHelper.ExBronKerb_Wiki();
            Graph h = GraphHelper.Complete(5);
            Assert.AreEqual(5, Clique.CliqueNumber(h));
            Assert.AreEqual(4, Clique.CliqueNumber(g));
        }
    }
}