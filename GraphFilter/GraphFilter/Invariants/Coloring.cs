using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    //book Teoria Computacional de Grafos, algoritmo 5.3
    public static class Coloring
    {
        public static int ChromaticNumber(Graph g)
        {
            int n = g.order;
            List<int> result = new List<int>(n);
            bool[] avaible = new bool[n];
            for (int i = 0; i < n; i++)
            {
                result.Add(-1);
                avaible[i] = true;
            }
            result[0] = 0;
            for (int u = 0; u < n; u++)
            {
                foreach (int i in g.N(u))
                {
                    if (result[i] != -1) avaible[result[i]] = false;
                }
                int cr;
                for (cr = 0; cr < n; cr++)
                {
                    if (avaible[cr]) break;
                }
                result[u] = cr;
                for (int i = 0; i < n; i++) avaible[i] = true;
            }
            return result.Distinct().Count();
        }
    }
}
