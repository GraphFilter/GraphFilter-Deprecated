using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex;
using Microsoft.Msagl.Core.DataStructures;
using Microsoft.Msagl.Core.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.InteropServices;

namespace GraphFilter.Invariants
{
    public class Utils
  {
        public static void DFS(int v, bool[] visited, Graph g)
        {
            visited[v] = true;

            List<int> vList = g.N(v);
            foreach (var n in vList)
                if (!visited[n]) DFS(n, visited, g);
        }
        public static class Distance
        {
            public static int[,] Matrix(Graph g)
            {
                int[,] dist = g.adjacencyMatrix;
                for (int i = 0; i < g.order; i++)
                {
                    for (int j = i + 1; j < g.order; j++)
                    {
                        if (g.adjacencyMatrix[i, j] == 0)
                        {
                            dist[i, j] = 1000000;
                            dist[j, i] = 1000000;
                        }
                    }
                }
                for (int k = 0; k < g.order; k++)
                    for (int i = 0; i < g.order; i++)
                        for (int j = 0; j < g.order; j++)
                        {
                                if (dist[i, j] > dist[i, k] + dist[k, j]) dist[i, j] = dist[i, k] + dist[k, j];
                        }
                return dist;
            }

            /*public static int DistanceDjikstra(Graph g, int source, int dest)
            {
                int[] dist = new int[g.order];
                SimplePriorityQueue<int> Q = new SimplePriorityQueue<int>();
                //HashSet<int> Q = new HashSet<int>();
                for (int v = 0; v < g.order; v++)
                {
                    //if (v!=source) dist[v] = int.MaxValue;
                    dist[v] = int.MaxValue;
                    Q.Enqueue(v, dist[v]);
                }
                while (Q.Count!=0)
                {
                    int u = Q.Dequeue();
                    foreach (int v in g.N(u))
                    {
                        int alt = dist[u] + 1;
                        if (alt < dist[v])
                        {
                            dist[v] = alt;
                            Q.TryUpdatePriority(v, alt);
                        }
                    }
                }
                return dist[dest];
            }*/        
        }

        public static class Spectral
        {

            public static double[,] AdjacencyMatrix(Graph g)
            {
                double[,] matrix = new double[g.order, g.order];
                for (int i = 0; i < g.order; i++)
                    for (int j = 0; j < g.order; j++)
                        matrix[i, j] = (double)g.adjacencyMatrix[i, j];
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
                            laplacian[i, j] = (double)-g.adjacencyMatrix[i, j];
                            laplacian[j, i] = (double)-g.adjacencyMatrix[i, j];
                        }
                        else
                        {
                            laplacian[i, j] = g.DegreeOf(i);
                        }
                    }
                }
                return laplacian;
            }

            public static int[,] SignlessLaplacianMatrix(Graph g)
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

            public static double ApproxToInt(double x)
            {
                if (Math.Abs(Math.Round(x) - x) < 0.0001) x = Math.Round(x);
                return x;
            }

        }

        public static class Clique
        {

            public static int MaxClique(Graph g, int lb, int max, HashSet<int> U)
            {
                max = lb;
                for (int i = 0; i < g.order; i++)
                {
                    if (g.DegreeOf(i) >= max)
                    {
                        U = new HashSet<int>();
                        foreach (int j in g.N(i))
                        {
                            if (j > i)
                                if (g.DegreeOf(j) >= max) U.Add(j);

                        }
                        max = CliqueBuild(g, U, 1, max);
                    }
                }
                return max;
            }

            private static int CliqueBuild(Graph g, HashSet<int> U, int size, int max)
            {
                if (U.Count == 0)
                {
                    if (size > max)
                    {
                        max = size;
                        return max;
                    }
                }
                while (U.Count > 0)
                {
                    if (size + U.Count <= max) return max;
                    int u = U.First<int>();
                    U.Remove(u);
                    HashSet<int> Nlinha = new HashSet<int>();
                    foreach (int w in g.N(u)) if (g.DegreeOf(w) >= max) Nlinha.Add(w);
                    max = CliqueBuild(g, Intersection(U, Nlinha), size + 1, max);
                }
                return max;
            }

        }
        private static HashSet<int> Union(HashSet<int> A, HashSet<int> B)
        {
            HashSet<int> aUb = new HashSet<int>(A);
            foreach (int x in B)
                if (!A.Contains(x)) aUb.Add(x);
            return aUb;
        }

        private static HashSet<int> Intersection(HashSet<int> A, HashSet<int> B)
        {
            HashSet<int> aIntb = new HashSet<int>();
            foreach (int x in B)
                if (A.Contains(x)) aIntb.Add(x);
            return aIntb;
        }

        public static class Coloring
        {
            private static int chi;
            private static Graph graph;

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
                Matrix<double> beta = MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfArray(Spectral.AdjacencyMatrix(g));
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

        public class Digraph_MaxFlow
        {
            //https://github.com/thormighti/MaximumFlow
            public int[,] matrix { get; private set; }
            public int order { get; private set; }
            public Digraph_MaxFlow(Graph g)
            {
                this.matrix = CostructFlowFrom(g);
                this.order = matrix.GetLength(0);
            }

            /*public void SetSource(int source)
            {
                for (int i = 0; i < order; i++)
                {
                    if (matrix[i,source]==1)
                    {
                        matrix[i, source] = 0;
                        matrix[source, i] = 1;
                    }
                }
            }

            public void SetDestination(int dest)
            {
                for (int i = 0; i < order; i++)
                {
                    if (matrix[dest,i] == 1)
                    {
                        matrix[i, dest] = 0;
                        matrix[dest, i] = 1;
                    }
                }
            }*/

            public int[,] CostructFlowFrom(Graph g)
            {
                int n = g.order;
                List<int[]> edges = g.Edges(); 
                int m = edges.Count;
                Dictionary<int, int[]> dic = new Dictionary<int, int[]>();
                int k = 0;
                //associa vertice a a dois vertices a1 a2
                for (int u = 0; u < n ; u++)
                {
                    dic[u] = new int[2] { k, k + 1 };
                    k = k + 2;
                }
                int[,] matrixFlow = new int[2 * n, 2 * n];
                //inclusão das arestas (a1,a2)
                for (int u = 0; u < n; u++) matrixFlow[(dic[u])[0], (dic[u])[1]] = 1;
                //associa aresta (a,b) a duas arestas (a2,b1) e (b2,a1)
                //a = edge[0] ; b=edge[1]
                //a1=(dic[edge[0]])[0] ; a2=(dic[edge[0]])[1]
                //b1=(dic[edge[1]])[0] ; b2=(dic[edge[1]])[1]
                foreach (int[] edge in edges)
                {
                    matrixFlow[(dic[edge[0]])[1], (dic[edge[1]])[0]] = 1; //(a2,b1)
                    matrixFlow[(dic[edge[1]])[0], (dic[edge[0]])[1]] = 1; //(b1,a2)//
                    matrixFlow[(dic[edge[1]])[1], (dic[edge[0]])[0]] = 1; //(b2,a1)
                    matrixFlow[(dic[edge[0]])[0], (dic[edge[1]])[1]] = 1; //(a1,b2)
                }
                return matrixFlow;
            }

            // checking if path exist with bfs
            public bool DoesPathExist(int[,] residualGraph, int source, int destination, int[] parent)
            {
                bool pathFound = false;
                // creating an array to check those already visited 
                bool[] visited = new bool[order];

                Queue<int> Q = new Queue<int>();
                // inserting the source and marking it as visited 
                Q.Enqueue(source);
                parent[source] = 1;   // marking this
                visited[source] = true;
                while (Q.Count != 0)
                {
                    int node = Q.Dequeue();
                    // visiting all the adjacents nodes 
                    for (int i = 0; i < order; i++)
                    {
                        if (visited[i] == false && residualGraph[node, i] > 0)  // residual capacity is strongly positive
                        {
                            Q.Enqueue(i);
                            parent[i] = node;
                            visited[i] = true;
                        }
                    }
                }
                // checking if BFS is reached 
                pathFound = visited[destination];
                return pathFound;
            }
            public int FindMaximumFlow(int source, int destination)
            {
                int[,] residualGraph = new int[order, order];
                // initiatilize Residual graph same as the Original graph
                for (int i = 0; i < residualGraph.GetLength(0); i++)
                {
                    for (int j = 0; j < residualGraph.GetLength(1); j++)
                    {
                        residualGraph[i, j] = matrix[i, j];
                    }
                }
                // parent var to store path of source to sink
                int[] parent = new int[order];
                int maxFlow = 0; // initializing the maximum flow
                while (DoesPathExist(residualGraph, source, destination, parent))
                {
                    //finding the capacity which can be passed into parent
                    int flow = int.MaxValue;
                    int T = destination;
                    while (T != source) // no self loop
                    {
                        int S = parent[T];
                        flow = Math.Min(flow, residualGraph[S, T]); // getting the min
                        T = S;

                    }
                    //update the residual graph
                    //reduce the capacity of forward edge by flow
                    // reduce the capacity of backward edge by flow
                    T = destination;
                    while (T != source)
                    {
                        int S = parent[T];
                        residualGraph[S, T] -= flow; // residual capacity from source 
                        residualGraph[T, S] += flow; // residual capacity from destination
                        T = S;
                    }
                    maxFlow += flow;
                }
                return maxFlow;
            }

        }
    }
}

