using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public static class Clique
    {
        public static int CliqueNumber(Graph g)
        {
            HashSet<int> R = new HashSet<int>();
            HashSet<int> X = new HashSet<int>();
            HashSet<int> P = new HashSet<int>(g.Vertices());
            BronKerbosch1(g, R, X, P);
        }

        public static HashSet<int>[] BronKerbosch1(Graph g, HashSet<int> R, HashSet<int> X, HashSet<int> P)
        {
            List<HashSet<int>> maximalCliques = new List<HashSet<int>>();
            if (P.Count == 0 && X.Count == 0) maximalCliques.Add(R);
            foreach (int v in P)
            {
                BronKerbosch1(g, R.UnionWith(new HashSet<int>(v)), P.IntersectWith(new HashSet<int>(g.N(v))), X.IntersectWith(new HashSet<int>(g.N(v))));
                P = P.IntersectWith(new HashSet<int>(v));
                X = X.UnionWith(new HashSet<int>(v));
            }
        }
    }
}
