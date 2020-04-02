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

        public static Graph Line(Graph g)
        {
            Dictionary<int,int[]> dic = new Dictionary<int, int[]>();
            int m = 0;
            foreach (int[] edge in g.Edges()) //map vertice-edge
            {
                dic[m] = edge;
                m++;
            }
            int[,] lineMatrix = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = i+1; j < m; j++)
                {
                    if (dic[i][0] == dic[j][0] || dic[i][1] == dic[j][0] || dic[i][0] == dic[j][1] || dic[i][1] == dic[j][1])
                    {
                        lineMatrix[i, j] = 1;
                        lineMatrix[j, i] = 1;
                    } 
                }
            }

            //deve retornar um Grafo linha do grafo de entrada
            return new Graph(lineMatrix);
        }


    }
}
