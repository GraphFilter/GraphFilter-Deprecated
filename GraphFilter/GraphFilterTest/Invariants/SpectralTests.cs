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
    public class SpectralTests
    {
        Graph wheel5 = GraphHelper.wheel_5();
        [TestMethod()]
        public void algebraicConnectivityTest()
        {
            double a = InvariantNum.AlgebricConnectivity.Calculate(wheel5); //a=2.381...
            Assert.IsTrue(a < 2.382 && a > 2.38);
            Graph g = GraphHelper.Complete(7);
            Assert.IsTrue(InvariantNum.AlgebricConnectivity.Calculate(g) == 7);
        }

        [TestMethod()]
        public void SpectralRadiusTest()
        {
            double a = InvariantNum.SpectralRadius.Calculate(wheel5); 
            Assert.IsTrue(a < 3.4495 && a > 3.4494);
        }

        [TestMethod()]
        public void LaplacianEnergyTest()
        {
            double a = InvariantNum.LaplacianEnergy.Calculate(wheel5); 
            Assert.IsTrue(a ==20);
        }

        [TestMethod()]
        public void AdjacencyEnergyTest()
        {
            double a = InvariantNum.AdjacencyEnergy.Calculate(wheel5); 
            Assert.IsTrue(a < 9.38 && a > 9.37);
        }
    }
}