using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter
{
    public static class Operation
    {
        public static Graph Complement(Graph g)
        {
            int[,] adjMatrix = g.adjacencyMatrix;
            int[,] complMatrix = new int[g.order, g.order];
            for (int i = 0; i < g.order; i++)
                for (int j = i + 1; j < g.order; j++)
                    if (adjMatrix[i, j] == 0)
                    {
                        complMatrix[i, j] = 1;
                        complMatrix[j, i] = 1;
                    }
            return new Graph(complMatrix);
        }

        public static Graph LineGraph(Graph g)
        {
            //deve retornar um Grafo linha do grafo de entrada
            return g;
        }


    }
}
