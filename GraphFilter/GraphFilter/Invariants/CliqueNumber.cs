using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuikGraph.Algorithms.Cliques;

namespace GraphFilter.Invariants
{
    public class CliqueNumber : Invariant
    {
        private static List<HashSet<int>> maximalCliques = new List<HashSet<int>>();
        private static int maximumClique = 0;
        
        public static int Calculate(Graph g)
        {
            HashSet<int> R = new HashSet<int>();
            HashSet<int> X = new HashSet<int>();
            HashSet<int> P = new HashSet<int>(g.Vertices());
            BronKerbosch1(g, R, P, X);
            return maximumClique;
            

        }
        public static string getName(Graph g) { return "Clique Number"; }

        private static HashSet<int> BronKerbosch1(Graph g, HashSet<int> R, HashSet<int> P, HashSet<int> X)
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
                    BronKerbosch1(g, Union(R, new HashSet<int> { v }), Intersection(P, new HashSet<int>(g.N(v))), Intersection(X, new HashSet<int>(g.N(v))));
                    X.UnionWith(new HashSet<int>(v));
                }
            }
            return null;
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
    }

    public class IndependenceNumber : Invariant
    {
        public static int Calculate(Graph g){return CliqueNumber.Calculate(Operation.Complement(g));}
        public static string getName(Graph g){ return "Independence Number";}

    }    
}
