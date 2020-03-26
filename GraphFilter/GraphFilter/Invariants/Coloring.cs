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

        /*private int x;
        public int ChromaticNumber(Graph g)
        {
            x = g.order;
            Cor(g);
            return x;
        }
        

        private void Cor(Graph g)
        {
            int n = g.order;
            if (g.Edges().Count == (n * (n - 1)) / 2)
            {
                this.x = Math.Min(x, n);
            }
            else
            {
                int[] noEdge = g.NoEdge();
                Cor(Alpha(noEdge[0], noEdge[1], g));
                Cor(Beta(noEdge[0], noEdge[1], g));
            }
        }

        private Graph Alpha(int v, int w, Graph g)
        {
            int[,] Hmatrix = g.adjacencyMatrix;
            Hmatrix[v, w] = 1;
            Hmatrix[w, v] = 1;
            return new Graph(Hmatrix);
        }

        private Graph Beta(int v, int w, Graph g)
        {
            int xlin;
            int ylin;
            int NovoID(int t)
            {
                if (t < w) return t;
                else return t - 1;
            }
            int[,] Hmatrix = new int[g.order - 1, g.order - 1];
            foreach (int[] e in g.Edges())
            {
                if (e[0] != w && e[1] != v) //e[0] is x and e[1] is y on the book
                {
                    xlin = NovoID(e[0]);
                    ylin = NovoID(e[1]);
                    Hmatrix[xlin, ylin] = 1;
                    Hmatrix[ylin, xlin] = 1;
                }
            }
            foreach (int x in g.N(w))
            {
                xlin = NovoID(x);
                ylin = NovoID(v);
                Hmatrix[xlin, ylin] = 1;
                Hmatrix[ylin, xlin] = 1;
            }
            return new Graph(Hmatrix);
        }*/





    }

}
