using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter
{
    public static class DOT_Converter
    {
        public static String G6toDOT(int[,] adj)
        {
            int order = adj.GetLength(0);
            String dot =  @"graph g{";

            //Inserindo os vértices na string
            //for (int i = 0; i < adj.Length; i++)   dot = dot + "\n" + i;

            //Inserindo as arestas na string
            for (int i = 0; i < order; i++)
                for (int j = i + 1; j < order; j++)
                    if (adj[i, j] == 1) dot = dot + "\n" + i + "--" + j; 
            return dot + "}";
        }
    }
}
