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
    public class DistancesTests
    {
        Graph g = GraphHelper.wheel_5();

        [TestMethod()]
        public void DistanceMatrixTest()
        {
            int[,] RealDistMatrix = new int[6, 6] { { 0, 1, 1, 1, 1, 1 }, { 1, 0, 1, 2, 2, 1 }, { 1, 1, 0, 1, 2, 2 }, { 1, 2, 1, 0, 1, 2 }, { 1, 2, 2, 1, 0, 1 }, { 1, 1, 2, 2, 1, 0 } };
            int[,] distMatrixWheel5 = Distances.DistanceMatrix(g);
            for (int i = 0; i < g.order; i++)
                for (int j = 0; j < g.order; j++) Assert.AreEqual(RealDistMatrix[i, j], distMatrixWheel5[i, j]);
        }

        [TestMethod()]
        public void DiameterTest()
        {
            Assert.AreEqual(2, Distances.Diameter(g));
        }
    }
}