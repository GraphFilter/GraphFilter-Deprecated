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
    public class OperationTests
    {
        Graph g = GraphHelper.ExBronKerb_Wiki();
       
        
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
            Assert.Fail();
        }
    }
}