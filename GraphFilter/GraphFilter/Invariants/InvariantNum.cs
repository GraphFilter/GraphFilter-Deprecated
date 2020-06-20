using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GraphPlanarityTesting.Graphs.DataStructures;
using GraphPlanarityTesting.PlanarityTesting.BoyerMyrvold;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;
using QuickGraph;
using QuikGraph;
using QuikGraph.Algorithms.VertexColoring;

namespace GraphFilter.Invariants
{
    public static class InvariantNum
    {
        public class AlgebricConnectivity
        {
            public static double Calculate(Graph g)
            {
                if (g.order == 0) return 0;
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
                if (g.order == 0) return 0;
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
                if (g.order == 0) return 0;
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
                if (g.order == 0) return 0;
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
                if (g.order == 0) return 0;
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
                if (g.order == 0) return 0;
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
                if (g.order == 0) return 0;
                int m = 0;
                for (int i = 0; i < g.order; i++)
                    for (int j = i+1; j < g.order; j++)
                        m = m + g.adjacencyMatrix[i, j];
                return m;
            }

            public static string getName() { return "Number of Edges"; }

            public static string getCode() { return "m"; }
        }

        public class CliqueNumber
        {
            private static HashSet<int> U;
            public static int Calculate(Graph g)
            {
                if (g.order == 0) return 0;
                return Utils.Clique.MaxClique(g, 0, 0, U);
            }
            public static string getName() { return "Clique Number"; }

            public static string getCode() { return "omega"; }
        }

        public class IndependenceNumber
        {
            public static int Calculate(Graph g) {
                if (g.order == 0) return 0; 
                return CliqueNumber.Calculate(Operation.Complement(g));
            }
            public static string getName() { return "Independence Number"; }

            public static string getCode() { return "alpha"; }


        }

        public class MatchingNumber
        {
            public static int Calculate(Graph g) {
                if (g.order == 0) return 0;
                return IndependenceNumber.Calculate(Operation.Line(g));
                
            }
            public static string getName() { return "Matching Number"; }

            public static string getCode() { return "Mx"; }
        }

        public class NumberOfComponents
        {
            public static int Calculate(Graph g)
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

            public static string getName() { return "Number of Components"; }

            public static string getCode() { return "Nc"; }
        }
        
        public class ChromaticNumber
        {
            //book Teoria Computacional de Grafos, algoritmo 5.3
            public static int Calculate(Graph g) { return Utils.Coloring.Calculate(g); }
            public static string getName() { return "Chromatic Number"; }

            public static string getCode() { return "chi"; }
        }

        public class VerticeConnectivy
        {
            //book Teoria Computacional de Grafos, algoritmo 5.3
            public static int Calculate(Graph g) {
                Utils.Digraph_MaxFlow digraph = new Utils.Digraph_MaxFlow(g);
                int minCut=int.MaxValue;
                int minCut_ij;
                for (int i = 0; i < digraph.order; i++)
                {
                    for (int j = 0; j < digraph.order; j++)
                    {
                        if (i!=j && digraph.matrix[i,j]!=1 && digraph.matrix[j, i] != 1)
                        {
                            minCut_ij = digraph.FindMaximumFlow(i, j);
                            if (minCut_ij < minCut) minCut = minCut_ij;
                        }
                        //digraph.SetDestination(i);
                        //digraph.SetDestination(j);   
                    }                   
                }

                if (minCut!=2)
                {
                    return minCut;
                }
                return minCut;
            
            }
            public static string getName() { return "Vertice Connectivy"; }

            public static string getCode() { return "k"; }
        }

        public class Girth
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

            public static int Calculate(Graph g) { return shortest_cycle(g); }
            public static string getName() { return "Girth"; }

            public static string getCode() { return "g"; }
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
            names.Add(VerticeConnectivy.getCode() + ": " + VerticeConnectivy.getName() + "\n");
            names.Add(Girth.getCode() + ": " + Girth.getName() + "\n");
            names.Add(NumberOfComponents.getCode() + ": " + NumberOfComponents.getName() + "\n");
            return String.Concat(names);
        }

    }

}

