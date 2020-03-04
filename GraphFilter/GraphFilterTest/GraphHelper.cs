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
        public static Graph wheel_5()
        {
            int[,] adjMatrix = new int[6, 6] { { 0, 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 0, 1 }, { 1, 1, 0, 1, 0, 0 }, { 1, 0, 1, 0, 1, 0 }, { 1, 0, 0, 1, 0, 1 }, { 1, 1, 0, 0, 1, 0 } };
            return new Graph(adjMatrix);
        }

        public static Graph Complete(int n)
        {
            int[,] adjMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) adjMatrix[i, j] = 0;
                    else adjMatrix[i, j] = 1;
                }              
            }
            return new Graph(adjMatrix);
        }
    }
}
