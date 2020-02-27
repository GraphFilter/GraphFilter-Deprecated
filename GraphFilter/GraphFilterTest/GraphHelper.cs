using GraphFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilterTest.GraphHelper
{
    public static class GraphHelper
    {
        public static Graph Whell_6()
        {
            int[,] adjMatrix = new int[6, 6] { { 0, 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 0, 1 }, { 1, 1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 1, 0 }, { 1, 0, 0, 1, 0, 1 }, { 1, 1, 0, 0, 1, 0 } };
            return new Graph(adjMatrix);
        }
    }
}
