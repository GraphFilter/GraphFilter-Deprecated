using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace GraphFilter.Invariants
{
    public static class Spectral
    {
        private static double[,] AdjacencyMatrix(Graph g)
        {
            double[,] matrix = new double[g.order, g.order];
            for (int i = 0; i < g.order; i++)
                for (int j = 0; j < g.order; j++)
                    matrix[i, j] = (double) g.adjacencyMatrix[i, j];
            return matrix;
        }
        
        public static double[,] LaplacianMatrix(Graph g)
        {
            double[,] laplacian = new double[g.order, g.order];
            for (int i = 0; i < g.order; i++)
            {
                for (int j = i; j < g.order; j++)
                {
                    if (i != j)
                    {
                        laplacian[i, j] = (double) -g.adjacencyMatrix[i, j];
                        laplacian[j, i] = (double) -g.adjacencyMatrix[i, j];
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
        public static double algebraicConnectivity(Graph g)
        {
            Matrix<double> lMatrix = DenseMatrix.OfArray(LaplacianMatrix(g));
            Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
            Vector<Complex> eigenvalues = evd.EigenValues;
            double a = eigenvalues.ElementAt(1).Real;
            return ApproxToInt(a);
        }

        public static double SpectralRadius(Graph g)
        {
            Matrix<double> lMatrix = DenseMatrix.OfArray(AdjacencyMatrix(g));
            Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
            Vector<Complex> eigenvalues = evd.EigenValues;
            return eigenvalues.ElementAt(g.order-1).Real;
        }

        public static double LaplacianEnergy(Graph g)
        {
            Matrix<double> lMatrix = DenseMatrix.OfArray(LaplacianMatrix(g));
            Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
            Vector<Complex> eigenvalues = evd.EigenValues;
            double energy = 0;
            for (int i = 0; i < g.order; i++) energy = energy + Math.Abs(eigenvalues.At(i).Real);
            return energy;
        }

        public static double AdjacencyEnergy(Graph g)
        {
            Matrix<double> lMatrix = DenseMatrix.OfArray(AdjacencyMatrix(g));
            Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
            Vector<Complex> eigenvalues = evd.EigenValues;
            double energy = 0;
            for (int i = 0; i < g.order; i++) energy = energy + Math.Abs(eigenvalues.At(i).Real);
            return energy;
        }

        private static double ApproxToInt(double x)
        {
            if (Math.Abs(Math.Round(x) - x) < 0.0001) x = Math.Round(x);
            return x;
        }
    }
}
