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
    public static class Invariant
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

            public static string getCode() { return "G"; }
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
            public static string getCode() { return "H"; }
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
            public static string getCode() { return "I"; }
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
            public static string getCode() { return "J"; }
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

            public static string getCode() { return "M"; }
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

            public static string getCode() { return "F"; }
        }

        public class IsConnected
        {
            public static bool Calculate(Graph g)
            {
                int[,] dist = Utils.Distance.Matrix(g);
                for (int i = 0; i < g.order; i++)
                {
                    for (int j = i + 1; j < g.order; j++)
                    {
                        if (dist[i, j] == 1000000 || dist[j, i] == 1000000)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            public static string getName() { return "Is a connected graph?"; }
        }

        public class MaxDegree
        {
            public static int Calculate(Graph g) { return g.sequenceDegree.Max(); }
            public static string getName() { return "Max Degree"; }

            public static string getCode() { return "B"; }

        }

        public class MinDegree
        {
            public static int Calculate(Graph g) { return g.sequenceDegree.Min(); }
            public static string getName() { return "Min Degree"; }
            public static string getCode() { return "C"; }
        }

        public class AverageDegree
        {
            public static double Calculate(Graph g)
            {
                return g.sequenceDegree.Average();
            }
            public static string getName() { return "Average Degree"; }
            public static string getCode() { return "D"; }
        }

        public class IsRegular
        {
            public static bool Calculate(Graph g)
            {
                for (int i = 0; i < g.order - 1; i++)
                {
                    if (g.sequenceDegree.ElementAt<int>(i) != g.sequenceDegree.ElementAt<int>(i + 1)) return false;
                }
                return true;
            }
            public static string getName() { return "Is a regular graph"; }
        }

        public class IsRegularWithDegree
        {
            public static bool Calculate(Graph g, int k)
            {
                for (int i = 0; i < g.order - 1; i++)
                {
                    if (g.sequenceDegree.ElementAt<int>(i) != k) return false;
                }
                return true;
            }
            public static string getName() { return "Is a regular graph with degree k"; }
        }

        public class Order
        {
            public static int Calculate(Graph g)
            {
                return g.order;
            }

            public static string getName() { return "Order of Graph"; }

            public static string getCode() { return "A"; }
        }

        public class CliqueNumber
        {
            private static HashSet<int> U;
            public static int Calculate(Graph g)
            { 
                return Utils.Clique.MaxClique(g, 0, 0, U);
            }
            public static string getName() { return "Clique Number"; }

            public static string getCode() { return "E"; }
        }

        public class IndependenceNumber
        {
            public static int Calculate(Graph g) { return CliqueNumber.Calculate(Operation.Complement(g)); }
            public static string getName() { return "Independence Number"; }

            public static string getCode() { return "L"; }


        }

        public class MatchingNumber
        {
            public static int Calculate(Graph g) { return CliqueNumber.Calculate(Operation.Complement(Operation.Line(g))); }
            public static string getName() { return "Matching Number"; }

            public static string getCode() { return "L"; }
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

            public static string getCode() { return "K"; }
        }
    }

}

