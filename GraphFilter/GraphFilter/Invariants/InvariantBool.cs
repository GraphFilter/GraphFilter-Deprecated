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

namespace GraphFilter.Invariants
{
    public static class InvariantBool
    {
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
                int?[,] graph = HamiltonianGraph.Utils.GraphUtil.FromMatrixFormat(Conversor.GraphToStringMatrix(g));
                int[] cycle = new BranchAndBound(graph).GetShortestHamiltonianCycle();
                return cycle.Length - 1 == g.order;
            }

            public static string getName() { return "Is a Hamiltonian Graph?"; }
        }
    }
}
