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
    }
}
