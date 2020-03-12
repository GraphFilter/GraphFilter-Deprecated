using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public class Clique
    {
        private List<HashSet<int>> maximalCliques = new List<HashSet<int>>();
        private int maximumClique = 0;

        public int CliqueNumber(Graph g)
        {
            HashSet<int> R = new HashSet<int>();
            HashSet<int> X = new HashSet<int>();
            HashSet<int> P = new HashSet<int>(g.Vertices());
            BronKerbosch1(g, R, P, X);
            return maximumClique;

        }

        private HashSet<int> BronKerbosch1(Graph g, HashSet<int> R, HashSet<int> P, HashSet<int> X)
        {
            if (P.Count == 0 && X.Count == 0)
            {
                maximalCliques.Add(R);
                if (R.Count > maximumClique) maximumClique = R.Count;
                return R;
            }
            if (P.Count != 0)
            {
                foreach (int v in P)
                {
                    BronKerbosch1(g, this.Union(R, new HashSet<int> { v }), this.Intersection(P, new HashSet<int>(g.N(v))), this.Intersection(X, new HashSet<int>(g.N(v))));
                    //P.Remove(v);
                    X.UnionWith(new HashSet<int>(v));
                }
            }
            return null;
        }

        private HashSet<int> Union(HashSet<int> A, HashSet<int> B)
        {
            HashSet<int> aUb = new HashSet<int>(A);
            foreach (int x in B)
                if (!B.Contains(x)) aUb.Add(x);
            return aUb;
        }

        private HashSet<int> Intersection(HashSet<int> A, HashSet<int> B)
        {
            HashSet<int> aIntb = new HashSet<int>();
            foreach (int x in B)
                if (A.Contains(x)) aIntb.Add(x);
            return aIntb;
        }
    }
}
