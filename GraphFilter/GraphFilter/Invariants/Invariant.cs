using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public static class Invariant
    {
        #region numerics
        public static int MaxDegree(Graph g) { return Degree.Max(g); }
        public static int MinDegree(Graph g)  { return Degree.Min(g); }
        public static  double AverageDegree(Graph g) { return Degree.Average(g); }
        public static int CliqueNumber(Graph g) { return Clique.CliqueNumber(g); }
        public static int Diameter(Graph g) { return Distances.Diameter(g); }
        public static double AlgebraicConnectivity(Graph g) { return Spectral.algebraicConnectivity(g); }
        public static double SpectralRadius(Graph g) { return Spectral.SpectralRadius(g); }
        public static double LaplacianEnergy(Graph g) { return Spectral.LaplacianEnergy(g); }
        public static double AdjacencyEnergy(Graph g) { return Spectral.AdjacencyEnergy(g); }
        public static int ChromaticNumber(Graph g) { return Coloring.ChromaticNumber(g); }
        public static int IndependenceNumber(Graph g) { return Clique.IndependenceNumber(g); }

        public static int NumberSpanningTree(Graph g) { return SpanningTree.NumberSpanningTree(g); }
        #endregion

        #region booleanos
        public static bool IsRegular(Graph g) { return Degree.IsRegular(g); }
        public static bool IsRegular(Graph g, int k) { return Degree.IsRegularWithDegree(g, k); }
        public static bool IsConnect(Graph g) { return Distances.IsConnected(g); }
        #endregion
    }
}

