using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GraphPlanarityTesting.Graphs.DataStructures;
using GraphPlanarityTesting.PlanarityTesting.BoyerMyrvold;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;
using MaximumFlowProblem;
using QuickGraph;
using QuikGraph;
using QuikGraph.Algorithms.VertexColoring;

namespace GraphFilter.Invariants
{
    interface IInvariant
    {
        double Calculate(Graph g);
        string getName();
        string getCode();
    }

    public static class InvariantNum
    {
        public static System.Collections.IEnumerable List()
        {
            var list = from t in Assembly.GetExecutingAssembly().GetTypes()
                       where t.GetInterfaces().Contains(typeof(IInvariant))
                                && t.GetConstructor(Type.EmptyTypes) != null
                       select Activator.CreateInstance(t) as IInvariant;

            return list;
        }
    }

        public class AlgebricConnectivity : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double a = eigenvalues.ElementAt(1).Real;
                return Utils.Spectral.ApproxToInt(a);
            }
            public string getName() { return "Algebraic Connectivity"; }

            public string getCode() { return "ac"; }

        }

    public class Nullity : IInvariant
    {
        public double Calculate(Graph g)
        {
            if (g.order == 0) return 0;
            Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
            return lMatrix.Nullity();
        }
        public string getName() { return "Nullity"; }

        public string getCode() { return "nul"; }
    }

    public class SpectralRadius : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double x = eigenvalues.ElementAt(g.order - 1).Real;
                return Utils.Spectral.ApproxToInt(x);
            }
            public string getName() { return "Spectral Radius"; }
            public string getCode() { return "lambda"; }
        }

        public class LaplacianEnergy : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double energy = 0;
                for (int i = 0; i < g.order; i++) energy = energy + Math.Abs(eigenvalues.At(i).Real);
                return energy;
            }
            public string getName() { return "Laplacian Energy"; }
            public string getCode() { return "El"; }
        }

        public class AdjacencyEnergy : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.AdjacencyMatrix(g));
                Evd<double> evd = lMatrix.Evd(Symmetricity.Symmetric);
                Vector<Complex> eigenvalues = evd.EigenValues;
                double energy = 0;
                for (int i = 0; i < g.order; i++) energy = energy + Math.Abs(eigenvalues.At(i).Real);
                return energy;
            }
            public string getName() { return "Energy"; }
            public string getCode() { return "Ea"; }
        }

        public class NumberSpanningTree : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                Matrix<double> lMatrix = DenseMatrix.OfArray(Utils.Spectral.LaplacianMatrix(g));
                lMatrix = lMatrix.RemoveColumn(g.order - 1).RemoveRow(g.order - 1);
                return (int)lMatrix.Determinant();
            }
            public string getName() { return "Number of spanning trees"; }

            public string getCode() { return "spnt"; }

        }

        public class Diameter : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                int[,] dist = Utils.Distance.Matrix(g);
                int diam = 0;
                for (int i = 0; i < g.order; i++)
                    for (int j = 0; j < g.order; j++)
                        if (dist[i, j] > diam) diam = dist[i, j];
                return diam;
            }
            public string getName() { return "Diameter"; }

            public string getCode() { return "diam"; }
        }



        public class MaxDegree : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                return g.sequenceDegree.Max();
            }
            public string getName() { return "Max Degree"; }

            public string getCode() { return "Delta"; }

        }

        public class MinDegree : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                return g.sequenceDegree.Min();
            }
            public string getName() { return "Min Degree"; }
            public string getCode() { return "d"; }
        }

        public class AverageDegree : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                return g.sequenceDegree.Average();
            }
            public string getName() { return "Average Degree"; }
            public string getCode() { return "delta"; }
        }

        public class Order : IInvariant
        {
            public double Calculate(Graph g)
            {
                return g.order;
            }

            public string getName() { return "Order of Graph"; }

            public string getCode() { return "n"; }
        }

        public class NumberOfEdges : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                int m = 0;
                for (int i = 0; i < g.order; i++)
                    for (int j = i + 1; j < g.order; j++)
                        m = m + g.adjacencyMatrix[i, j];
                return m;
            }

            public string getName() { return "Number of Edges"; }

            public string getCode() { return "m"; }
        }

        public class CliqueNumber : IInvariant
        {
            private static HashSet<int> U;
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                return Utils.Clique.MaxClique(g, 0, 0, U);
            }
            public string getName() { return "Clique Number"; }

            public string getCode() { return "omega"; }
        }

        public class IndependenceNumber : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                CliqueNumber cn = new CliqueNumber();
                return cn.Calculate(Operation.Complement(g));
            }
            public string getName() { return "Independence Number"; }

            public string getCode() { return "alpha"; }


        }

        public class MatchingNumber : IInvariant
        {
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                IndependenceNumber ic = new IndependenceNumber();
                return ic.Calculate(Operation.Line(g));
            }
            public string getName() { return "Matching Number"; }

            public string getCode() { return "Mx"; }
        }

        public class NumberOfComponents : IInvariant
        {
            public double Calculate(Graph g)
            {
                int nc = 1;

                if (g.order == 0) return 0;

                bool[] visited = new bool[g.order];

                Utils.DFS(0, visited, g);

                for (int i = 0; i < g.order; i++)
                {
                    if (!visited[i])
                    {
                        nc++;
                        Utils.DFS(i, visited, g);
                    }
                }

                return nc;
            }

            public string getName() { return "Number of Components"; }

            public string getCode() { return "Nc"; }
        }

        public class ChromaticNumber : IInvariant
        {
            //book Teoria Computacional de Grafos, algoritmo 5.3
            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                return Utils.Coloring.Calculate(g);
            }
            public string getName() { return "Chromatic Number"; }

            public string getCode() { return "chi"; }
        }

        public class EdgeConnectivy : IInvariant
        {
            //https://github.com/lucasrabiec/MaximumFlowProblem
            public double Calculate(Graph g)
            {
                if (g.order == 0 || !InvariantBool.IsConnected.Calculate(g)) return 0;
                FordFulkerson fordF = new FordFulkerson(g.adjacencyMatrix);
                return fordF.FindMaximumFlow();
            }
            public string getName() { return "Edge Connectivy"; }

            public string getCode() { return "ec"; }
        }

        public class Girth : IInvariant
        {
            //https://www.geeksforgeeks.org/shortest-cycle-in-an-undirected-unweighted-graph/
            private static int shortest_cycle(Graph g)
            {
                int n = g.order;
                // To store length of the shortest cycle  
                int ans = int.MaxValue;
                // For all vertices  
                for (int i = 0; i < n; i++)
                {
                    // Make distance maximum  
                    int[] dist = new int[n];
                    fill(dist, (int)1e9);
                    // Take a imaginary parent  
                    int[] par = new int[n];
                    fill(par, -1);
                    // Distance of source to source is 0  
                    dist[i] = 0;
                    List<int> q = new List<int>();
                    // Push the source element  
                    q.Add(i);
                    // Continue until queue is not empty  
                    while (q.Count != 0)
                    {
                        // Take the first element  
                        int x = q[0];
                        q.RemoveAt(0);
                        // Traverse for all it's childs  
                        foreach (int child in g.N(x))
                        {
                            // If it is not visited yet  
                            if (dist[child] == (int)(1e9))
                            {
                                // Increase distance by 1  
                                dist[child] = 1 + dist[x];
                                // Change parent  
                                par[child] = x;
                                // Push into the queue  
                                q.Add(child);
                            }
                            else if (par[x] != child && par[child] != x)
                                ans = Math.Min(ans, dist[x] + dist[child] + 1);
                        }
                    }
                }
                return ans;
            }
            private static int[] fill(int[] arr, int val)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                    arr[i] = val;
                return arr;
            }

            public double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                return shortest_cycle(g);
            }
            public string getName() { return "Girth"; }

            public string getCode() { return "g"; }
        }

} 

