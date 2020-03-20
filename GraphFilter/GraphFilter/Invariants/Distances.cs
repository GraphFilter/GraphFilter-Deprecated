using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public static class Distances
    {
        private static int[,] FloydWarshall_0(Graph g)
        {
            int[,] adjMatrix = g.adjacencyMatrix;
            int[,] distanceMatrix = adjMatrix;
            for (int i = 0; i < g.order; i++)
            {
                for (int j = i + 1; j < g.order; j++)
                {
                    if (adjMatrix[i, j] == 0)
                    {
                        distanceMatrix[i, j] = 1000000;
                        distanceMatrix[j, i] = 1000000;
                    }
                }
            }
            return distanceMatrix;
        }

        public static int[,] DistanceMatrix(Graph g)
        {
            int[,] dist = FloydWarshall_0(g);
            for (int k = 0; k < g.order; k++)
                for (int i = 0; i < g.order; i++)
                    for (int j = 0; j < g.order; j++)
                    {              
                            if (dist[i, j] > dist[i, k] + dist[k, j]) dist[i, j] = dist[i, k] + dist[k, j];  
                    }
            return dist;
        }

        public static int Diameter(Graph g)
        {
            int[,] dist = DistanceMatrix(g);
            int diam = 0;
            for (int i = 0; i < g.order; i++)
                for (int j = 0; j < g.order; j++)
                    if (dist[i, j] > diam) diam = dist[i, j];
            return diam;
        }

        public static bool IsConnected(Graph g)
        {
            int[,] dist = DistanceMatrix(g);
            for (int i = 0; i < g.order; i++)
            {
                for (int j = i + 1; j < g.order; j++)
                {
                    if(dist[i, j] == 1000000 || dist[j, i] == 1000000)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
