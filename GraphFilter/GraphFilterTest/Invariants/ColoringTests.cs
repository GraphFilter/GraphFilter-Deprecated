using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphFilter.Invariants;
using GraphFilterTest.GraphHelper;

namespace GraphFilter.Invariants.Tests
{
    [TestClass()]
    public class ColoringTests
    {
        [TestMethod()]
        public void ChromaticNumberTest()
        {
            //Coloring color = new Coloring();     
            Assert.AreEqual(4, ChromaticNumber.Calculate(GraphHelper.wheel_5()));
            Assert.AreEqual(3, ChromaticNumber.Calculate(GraphHelper.NotConnected()));
            Assert.AreEqual(3, ChromaticNumber.Calculate(GraphHelper.ExBronKerb_Wiki()));
            Assert.AreEqual(5, ChromaticNumber.Calculate(GraphHelper.Complete(5)));
        }
    }
}