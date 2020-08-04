using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex;

namespace GraphFilter.Invariants
{
    public class UtilsColoring
    {
        private int _chi;
        
        private Graph Alpha(int v, int w, Graph g)
        {
            //baseado no Algoritmo 5.3 do Livro Jayme.
            int[,] alphaMatrix = g.adjacencyMatrix;
            alphaMatrix[v, w] = 1;
            alphaMatrix[w, v] = 1;
            return new Graph(alphaMatrix);
        }

        private Graph Beta(int v, int w, Graph g)
        {
            Matrix<double> beta = MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
            for (int k = 0; k < g.order; k++)
            {
                if (beta[v, k] + beta[w, k] > 0) beta[v, k] = 1;
                else beta[v, k] = 0;
                if (beta[k, v] + beta[k, w] > 0) beta[k, v] = 1;
                else beta[k, v] = 0;
            }
            beta = beta.RemoveColumn(w).RemoveRow(w);
            int[,] betaSub = new int[g.order - 1, g.order - 1];
            for (int i = 0; i < g.order - 1; i++) for (int j = 0; j < g.order - 1; j++) betaSub[i, j] = (int)beta[i, j];
            return new Graph(betaSub);
        }

        private void Cor(Graph g)
        {
            
            if (g.NumberEdges()==g.order*(g.order-1)/2)
            {
                _chi = Math.Min(_chi, g.order);
            }
            else
            {
                int[] noEdge = g.NoEdge();
                Cor(Alpha(noEdge[0], noEdge[1],g));
                Cor(Beta(noEdge[0], noEdge[1],g));
            }
        }

        public int Calculate(Graph g)
        {
            Cor(g);
            return _chi;
        }
    }
}
