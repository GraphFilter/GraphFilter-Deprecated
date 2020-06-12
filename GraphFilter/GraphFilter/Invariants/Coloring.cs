using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public static class Coloring
    {
        private static int chi;
        private static Graph graph;
        /*public Coloring(Graph g) { 
            graph = g;
            chi = graph.order;
        }*/
        
        private static Graph Alpha(int v, int w, Graph g)
        {
            //baseado no Algoritmo 5.3 do Livro Jayme.
            int[,] alphaMatrix = g.adjacencyMatrix;
            alphaMatrix[v, w] = 1;
            alphaMatrix[w, v] = 1;
            return new Graph(alphaMatrix);
        }

        private static Graph Beta(int v, int w, Graph g)
        {
            /*int[,] beta = g.adjacencyMatrix;
            for (int k = 0; k < g.order; k++)
            {
                if (beta[v, k] + beta[w, k] > 0) beta[v, k] = 1;
                else beta[v, k] = 0;
                if (beta[k, v] + beta[k, w] > 0) beta[k, v] = 1;
                else beta[k, v] = 0;
            }
            int[,] betaSub = new int[beta.GetLength(0)-1, beta.GetLength(1) - 1];
            for (int i = 0; i < g.order; i++)
            {
                for (int j = 0; j < g.order; j++)
                {
                    if (i < w && j < w) betaSub[i, j] = beta[i, j];
                    if (i > w && j < w) betaSub[i - 1, j] = beta[i, j];
                    if (i < w && j > w) betaSub[i, j - 1] = beta[i, j];
                    if (i > w && j > w) betaSub[i - 1, j - 1] = beta[i, j];
                    if (i == j && i<g.order-1) betaSub[i, j] = 0;
                }
            }
            Graph betaSubG = new Graph(betaSub);
            return betaSubG;*/
            Matrix<double> beta = DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
            for (int k = 0; k < g.order; k++)
            {
                if (beta[v, k] + beta[w, k] > 0) beta[v, k] = 1;
                else beta[v, k] = 0;
                if (beta[k, v] + beta[k, w] > 0) beta[k, v] = 1;
                else beta[k, v] = 0;
            }
            beta = beta.RemoveColumn(w).RemoveRow(w);
            int[,] betaSub = new int[g.order - 1, g.order - 1];
            for (int i = 0; i < g.order-1; i++) for (int j = 0; j < g.order-1; j++) betaSub[i, j] = (int)beta[i, j];
            return new Graph(betaSub);
        }

        private static void Cor(Graph g)
        {
            int[] noEdge = g.NoEdge();
            if (noEdge == null)
            {
                chi = Math.Min(chi, g.order);
                if (g.order == 6)
                {
                    int m = g.order;
                }
            }
            else
            {
                Cor(Beta(noEdge[0], noEdge[1], g));
                Cor(Alpha(noEdge[0], noEdge[1], g));
                
            }
        }

        public static int Calculate(Graph g)
        {
            chi = g.order;
            Cor(g);
            return chi;
        }

    }
}
