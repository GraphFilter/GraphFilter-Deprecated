using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Tests
{
    [TestClass()]
    public class ConversorTests
    {
        [TestMethod()]
        public void Graph6toAdjMatrixTest()
        {
            int[,] adjMatrix = new int[6, 6] { { 0, 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 0, 1 }, { 1, 1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 1, 0 }, { 1, 0, 0, 1, 0, 1 }, { 1, 1, 0, 0, 1, 0 } };
            int[,] adjMatrixFromG6 = Conversor.Graph6toAdjMatrix("E|fG");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Assert.AreEqual(adjMatrix[i,j], adjMatrixFromG6[i,j]);
                }
            }
        }
    }
}