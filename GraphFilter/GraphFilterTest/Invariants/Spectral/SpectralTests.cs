using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter.Invariants.Spectral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphFilterTest.GraphHelper;

namespace GraphFilter.Invariants.Spectral.Tests
{
    [TestClass()]
    public class SpectralTests
    {
        Graph wheel5 = GraphHelper.wheel_5();
        [TestMethod()]
        public void algebraicConnectivityTest()
        {
            double a = Spectral.algebraicConnectivity(wheel5); //a=2.381...
            Assert.IsTrue(a < 2.382 && a > 2.38);
            Graph g = GraphHelper.Complete(7);
            Assert.IsTrue(Spectral.algebraicConnectivity(g) == 7);
        }

        [TestMethod()]
        public void SpectralRadiusTest()
        {
            double a = Spectral.SpectralRadius(wheel5); 
            Assert.IsTrue(a < 3.4495 && a > 3.4494);
        }

        [TestMethod()]
        public void LaplacianEnergyTest()
        {
            double a = Spectral.LaplacianEnergy(wheel5); 
            Assert.IsTrue(a ==20);
        }

        [TestMethod()]
        public void AdjacencyEnergyTest()
        {
            double a = Spectral.AdjacencyEnergy(wheel5); 
            Assert.IsTrue(a < 9.38 && a > 9.37);
        }
    }
}