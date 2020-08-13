using GraphPlanarityTesting.Graphs.DataStructures;
using GraphPlanarityTesting.PlanarityTesting.BoyerMyrvold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamiltonianGraph;
using System.Drawing.Text;
using GraphPlanarityTesting.Graphs.Algorithms;
using System.Windows.Navigation;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;
using System.Numerics;

namespace GraphFilter.Invariants
{
    public static class InvariantBool
    {
        public class IsAcyclic
        {
            public static bool Calculate(Graph g)
            {
                Girth girth = new Girth();
                return girth.Calculate(g) == int.MaxValue;
            }

            public static string getName() { return "Is acyclic graph?"; }
        }

        public class IsConnected
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;

                bool[] visited = new bool[g.order];

                Utils.DFS(0, visited, g);

                for (int i = 0; i < g.order; i++) if (!visited[i]) return false;
                return true;
            }

            public static string getName() { return "Is a connected graph?"; }
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

        public class IsPlanar
        {
            //https://github.com/OndrejNepozitek/GraphPlanarityTesting
            public static bool Calculate(Graph g)
            {
                var graph = new UndirectedAdjacencyListGraph<int>();
                for (int i = 0; i < g.order; i++) graph.AddVertex(i);

                for (int i = 0; i < g.order; i++)
                    for (int j = i + 1; j < g.order; j++)
                        if (g.adjacencyMatrix[i, j] == 1) graph.AddEdge(i, j);

                var boyerMyrvold = new BoyerMyrvold<int>();
                return boyerMyrvold.IsPlanar(graph);
            }

            public static string getName() { return "Is a Planar Graph?"; }

        }

        public class IsHamiltonian
        {
            //https://github.com/sagidM/HamiltonianGraph/blob/master/src/HamiltonianGraph/BranchAndBound.cs
            public static bool Calculate(Graph g)
            {
                int?[,] graph = HamiltonianGraph.Utils.GraphUtil.FromMatrixFormat(GraphToStringMatrix(g));
                int[] cycle = new BranchAndBound(graph).GetShortestHamiltonianCycle();
                if (cycle == null) return false;
                return cycle.Length - 1 == g.order;
            }

            private static string GraphToStringMatrix(Graph g)
            {
                //Função para convertor o grafo para o formato aceito no pacote Hamiltonian Graph
                int[,] adjMatrix = g.adjacencyMatrix;
                string graph = g.order + "\n";
                for (int i = 0; i < g.order; i++)
                {
                    for (int j = 0; j < g.order; j++)
                    {
                        if (adjMatrix[i, j] == 0) graph = graph + "- ";
                        else graph = graph + adjMatrix[i, j] + " ";
                    }
                    graph.Remove(graph.Length - 1);
                    graph = graph + "\n";
                }
                return graph;
            }

            public static string getName() { return "Is a Hamiltonian Graph?"; }
        }

        public class Largest_A_IsInteger
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double x = eigenvalues.ElementAt(g.order - 1).Real;
                return Utils.Spectral.ApproxToInt(x) % 1 == 0;
            }
            public string getName() { return "Largest adj eigen Integer"; }
        }

        public class Largest_L_IsInteger
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double x = eigenvalues.ElementAt(g.order - 1).Real;
                return Utils.Spectral.ApproxToInt(x) % 1 == 0;
            }
            public string getName() { return "Largest Laplacian eigen Integer"; }
        }

        public class Largest_Q_IsInteger
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.SignlessLaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double x = eigenvalues.ElementAt(g.order - 1).Real;
                return Utils.Spectral.ApproxToInt(x) % 1 == 0;
            }
            public string getName() { return "Largest Signless Laplacian eigen Integer"; }
        }

        public class A_integral
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                foreach (Complex eig in eigenvalues)
                {
                    if (Utils.Spectral.ApproxToInt(eig.Real) % 1 != 0) return false;
                }
                return true;
            }
            public string getName() { return "Integral Adjacency Spectrum"; }
        }

        public class L_integral
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                foreach (Complex eig in eigenvalues)
                {
                    if (Utils.Spectral.ApproxToInt(eig.Real) % 1 != 0) return false;
                }
                return true;
            }
            public string getName() { return "Integral Laplacian Spectrum"; }
        }

        public class Q_integral
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.SignlessLaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                foreach (Complex eig in eigenvalues)
                {
                    if (Utils.Spectral.ApproxToInt(eig.Real) % 1 != 0) return false;
                }
                return true;
            }
            public string getName() { return "Integral Signless Laplacian Spectrum"; }
        }

        public class SomeEig_A_integer
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                foreach (Complex eig in eigenvalues)
                {
                    if (Utils.Spectral.ApproxToInt(eig.Real) % 1 == 0) return true;
                }
                return false;
            }
            public string getName() { return "Integral Laplacian Spectrum"; }
        }

        public class SomeEig_L_integer
        {
            public static bool Calculate(Graph g)
            {
                if (g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                foreach (Complex eig in eigenvalues)
                {
                    if (Utils.Spectral.ApproxToInt(eig.Real) % 1 == 0) return true;
                }
                return false;
            }
            public string getName() { return "Integral Laplacian Spectrum"; }
        }

        public class SomeEig_Q_integer
        {
            public static bool Calculate(Graph g)
            {
                if(g.order == 0) return true;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.SignlessLaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                foreach (Complex eig in eigenvalues)
                {
                    if (Utils.Spectral.ApproxToInt(eig.Real) % 1 == 0) return true;
                }
                return false;
            }
            public string getName() { return "Integral Signless Laplacian Spectrum"; }
        }
    }
}
