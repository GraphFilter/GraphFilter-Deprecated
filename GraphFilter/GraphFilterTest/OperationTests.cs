using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphFilterTest.GraphHelper;
using GraphFilter.Invariants;

namespace GraphFilter.Tests
{
    [TestClass()]
    public class OperationTests
    {
        Graph g = GraphHelper.ExBronKerb_Wiki();
        Graph k7 = GraphHelper.Complete(7);
        [TestMethod()]
        public void ComplementTest()
        {
            int[,] complMatrix = new int[,] { { 0, 0, 1, 1, 0, 1 }, { 0, 0, 0, 1, 0, 1 }, { 1, 0, 0, 0, 1, 1 }, { 1, 1, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0, 1 }, { 1, 1, 1, 0, 1, 0 } };
            for (int i = 0; i < g.order; i++)
            {
                for (int j = 0; j < g.order; j++)
                {
                    Assert.AreEqual(complMatrix[i, j], Operation.Complement(g).adjacencyMatrix[i, j]);
                }
            }
        }

        [TestMethod()]
        public void LineGraphTest()
        {
            Graph lg = Operation.Line(g);
            int[,] lgmatrix = lg.adjacencyMatrix;
            double a_lg = InvariantNum.AlgebricConnectivity.Calculate(Operation.Line(g));
            Assert.IsTrue(1.21711 < a_lg && a_lg < 1.21712);

            double a_lk7 = InvariantNum.AlgebricConnectivity.Calculate(Operation.Line(k7));
            Assert.AreEqual(7,a_lk7);


        }
    }
}