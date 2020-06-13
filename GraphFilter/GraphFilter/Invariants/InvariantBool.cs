using GraphPlanarityTesting.Graphs.DataStructures;
using GraphPlanarityTesting.PlanarityTesting.BoyerMyrvold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamiltonianGraph;

namespace GraphFilter.Invariants
{
    public static class InvariantBool
    {
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

            public static string getName() { return "Planarity Test"; }

        }

        public class IsHamiltonian
        {
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
