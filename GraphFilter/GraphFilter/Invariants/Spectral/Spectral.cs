using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants.Spectral
{
    public static class Spectral
    {
        private static int[,] AdjacencyMatrix(Graph g)
        {
            return g.adjacencyMatrix;
        }
        
        private static int[,] LaplacianMatrix(Graph g)
        {
            int[,] laplacian = new int[g.order, g.order];
            for (int i = 0; i < g.order; i++)
            {
                for (int j = i; j < g.order; j++)
                {
                    if (i != j)
                    {
                        laplacian[i, j] = -g.adjacencyMatrix[i, j];
                        laplacian[j, i] = -g.adjacencyMatrix[i, j];
                    }
                    else
                    {
                        laplacian[i, j] = g.DegreeOf(i);
                    }                    
                }
            }
            return laplacian;
        }

        private static int[,] SignlessLaplacianMatrix(Graph g)
        {
            int[,] laplacian = new int[g.order, g.order];
            for (int i = 0; i < g.order; i++)
            {
                for (int j = i; j < g.order; j++)
                {
                    if (i != j)
                    {
                        laplacian[i, j] = g.adjacencyMatrix[i, j];
                        laplacian[j, i] = g.adjacencyMatrix[i, j];
                    }
                    else
                    {
                        laplacian[i, j] = g.DegreeOf(i);
                    }
                }
            }
            return laplacian;
        }
        public algebraicConnectivity(Graph g)
        {
           
        }
    }
}
