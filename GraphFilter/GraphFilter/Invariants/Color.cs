using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public class Color //baseado no livro do Jayme, pág 153
    {
        
        private int X;
        public void ColorGraph(Graph g)
        {
            int n = g.order;
            int m = g.Edges().Count;
            if (m==(n*(n-1))/2)
            {
                X = Math.Min(X, n);
            }
            else
            {
                int[] noEdge = this.noEdge(g);
                ColorGraph(alfa(noEdge[0], noEdge[1], g));
                ColorGraph(beta(noEdge[0], noEdge[1], g));
            }
        }

        public int[] noEdge(Graph g)
        {
            for (int i = 0; i < g.order; i++)
                for (int j = i+1; j < g.order; j++)
                {
                    if (!g.adjacent(i, j)) return new int[2] { i, j };
                }
            return null;
        }

        public Graph alfa(int v, int w, Graph g)
        {
            Graph H = new Graph(g.adjacencyMatrix);
            H.insertEdge(v, w);
            return H;
        }

        public Graph beta(int v, int w, Graph g) //terminar
        {
            Graph H = new Graph(g.adjacencyMatrix);
            H.insertEdge(v, w);
            return H;
        }
    }
}
