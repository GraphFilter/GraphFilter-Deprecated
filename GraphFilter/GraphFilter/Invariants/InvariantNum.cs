using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GraphPlanarityTesting.Graphs.DataStructures;
using GraphPlanarityTesting.PlanarityTesting.BoyerMyrvold;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace GraphFilter.Invariants
{
    public static class InvariantNum
    {
        public class AlgebricConnectivity
        {
            public static double Calculate(Graph g)
            {
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double a = eigenvalues.ElementAt(1).Real;
                return Utils.Spectral.ApproxToInt(a);
            }
            public static string getName() { return "Algebraic Connectivity"; }

            public static string getCode() { return "ac"; }
        }

        public class SpectralRadius
        {
            public static double Calculate(Graph g)
            {
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                return eigenvalues.ElementAt(g.order - 1).Real;
            }
            public static string getName() { return "Spectral Radius"; }
            public static string getCode() { return "lambda"; }
        }

        public class LaplacianEnergy
        {
            public static double Calculate(Graph g)
            {
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double energy = 0;
                for (int i = 0; i < g.order; i++) energy = energy + Math.Abs(eigenvalues.At(i).Real);
                return energy;
            }
            public static string getName() { return "Laplacian Energy"; }
            public static string getCode() { return "El"; }
        }

        public class AdjacencyEnergy
        {
            public static double Calculate(Graph g)
            {
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double energy = 0;
                for (int i = 0; i < g.order; i++) energy = energy + Math.Abs(eigenvalues.At(i).Real);
                return energy;
            }
            public static string getName() { return "Energy"; }
            public static string getCode() { return "Ea"; }
        }

        public class NumberSpanningTree
        {
            public static int Calculate(Graph g)
            {
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                lMatrix = lMatrix.RemoveColumn(g.order - 1).RemoveRow(g.order - 1);
                return (int)lMatrix.Determinant();
            }
            public static string getName() { return "Number of spanning trees"; }

            public static string getCode() { return "spnt"; }
        }

        public class Diameter
        {
            public static int Calculate(Graph g)
            {
                int[,] dist = Utils.Distance.Matrix(g);
                int diam = 0;
                for (int i = 0; i < g.order; i++)
                    for (int j = 0; j < g.order; j++)
                        if (dist[i, j] > diam) diam = dist[i, j];
                return diam;
            }
            public static string getName() { return "Diameter"; }

            public static string getCode() { return "diam"; }
        }

        

        public class MaxDegree
        {
            public static int Calculate(Graph g) { return g.sequenceDegree.Max(); }
            public static string getName() { return "Max Degree"; }

            public static string getCode() { return "Delta"; }

        }

        public class MinDegree
        {
            public static int Calculate(Graph g) { return g.sequenceDegree.Min(); }
            public static string getName() { return "Min Degree"; }
            public static string getCode() { return "d"; }
        }

        public class AverageDegree
        {
            public static double Calculate(Graph g)
            {
                return g.sequenceDegree.Average();
            }
            public static string getName() { return "Average Degree"; }
            public static string getCode() { return "delta"; }
        }     

        public class Order
        {
            public static int Calculate(Graph g)
            {
                return g.order;
            }

            public static string getName() { return "Order of Graph"; }

            public static string getCode() { return "n"; }
        }

        public class NumberOfEdges
        {
            public static int Calculate(Graph g)
            {
                return g.Edges().Count;
            }

            public static string getName() { return "Number of Edges"; }

            public static string getCode() { return "m"; }
        }

        public class CliqueNumber
        {
            private static HashSet<int> U;
            public static int Calculate(Graph g)
            { 
                return Utils.Clique.MaxClique(g, 0, 0, U);
            }
            public static string getName() { return "Clique Number"; }

            public static string getCode() { return "omega"; }
        }

        public class IndependenceNumber
        {
            public static int Calculate(Graph g) { return CliqueNumber.Calculate(Operation.Complement(g)); }
            public static string getName() { return "Independence Number"; }

            public static string getCode() { return "alpha"; }


        }

        public class MatchingNumber
        {
            public static int Calculate(Graph g) { return CliqueNumber.Calculate(Operation.Complement(Operation.Line(g))); }
            public static string getName() { return "Matching Number"; }

            public static string getCode() { return "M"; }
        }
        
        public class ChromaticNumber
        {
            //book Teoria Computacional de Grafos, algoritmo 5.3
            public static int Calculate(Graph g)
            {
                int n = g.order;
                List<int> result = new List<int>(n);
                bool[] avaible = new bool[n];
                for (int i = 0; i < n; i++)
                {
                    result.Add(-1);
                    avaible[i] = true;
                }
                result[0] = 0;
                for (int u = 0; u < n; u++)
                {
                    foreach (int i in g.N(u))
                    {
                        if (result[i] != -1) avaible[result[i]] = false;
                    }
                    int cr;
                    for (cr = 0; cr < n; cr++)
                    {
                        if (avaible[cr]) break;
                    }
                    result[u] = cr;
                    for (int i = 0; i < n; i++) avaible[i] = true;
                }
                return result.Distinct().Count();
            }
            public static string getName() { return "Chromatic Number"; }

            public static string getCode() { return "chi"; }
        }

        public static string AllNames()
        {
            List<string> names = new List<string>();
            names.Add(AlgebricConnectivity.getCode() + ": "+AlgebricConnectivity.getName()+"\n");
            names.Add(SpectralRadius.getCode() + ": " + SpectralRadius.getName() + "\n");
            names.Add(LaplacianEnergy.getCode() + ": " + LaplacianEnergy.getName() + "\n");
            names.Add(AdjacencyEnergy.getCode() + ": " + AdjacencyEnergy.getName() + "\n");
            names.Add(NumberSpanningTree.getCode() + ": " + NumberSpanningTree.getName() + "\n");
            names.Add(Diameter.getCode() + ": " + Diameter.getName() + "\n");
            names.Add(MaxDegree.getCode() + ": " + MaxDegree.getName() + "\n");
            names.Add(MinDegree.getCode() + ": " + MinDegree.getName() + "\n");
            names.Add(AverageDegree.getCode() + ": " + AverageDegree.getName() + "\n");
            names.Add(Order.getCode() + ": " + Order.getName() + "\n");
            names.Add(CliqueNumber.getCode() + ": " + CliqueNumber.getName() + "\n");
            names.Add(IndependenceNumber.getCode() + ": " + IndependenceNumber.getName() + "\n");
            names.Add(MatchingNumber.getCode() + ": " + MatchingNumber.getName() + "\n");
            names.Add(ChromaticNumber.getCode() + ": " + ChromaticNumber.getName() + "\n");
            return String.Concat(names);

        }

    }

}

