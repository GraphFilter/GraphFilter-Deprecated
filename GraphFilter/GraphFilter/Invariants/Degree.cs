using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public static class Degree
    {
        public static int Max(Graph g)
        {
            return g.sequenceDegree.Max();
        }

        public static int Min(Graph g)
        {
            return g.sequenceDegree.Min();
        }

        public static double Average(Graph g)
        {
            return g.sequenceDegree.Average();
        }

        public static bool IsRegular(Graph g)
        {
            for (int i = 0; i < g.order - 1; i++)
            {
                if (g.sequenceDegree.ElementAt<int>(i) != g.sequenceDegree.ElementAt<int>(i + 1)) return false;
            }
            return true;
        }

        public static bool IsRegularWithDegree(Graph g, int k)
        {
            for (int i = 0; i < g.order - 1; i++)
                if (g.sequenceDegree.ElementAt<int>(i) != k) return false;
            return true;
        }
    }
}
