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
            int m = g.Edges().Count;

            for (int i = 0; i < m; i++) dic[i] = g.Edges().ElementAt(i);            
            int[,] lineMatrix = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = i+1; j < m; j++)
                {  
                    if ((dic[i])[0] == (dic[j])[0] || (dic[i])[1] == (dic[j])[0] || (dic[i])[0] == (dic[j])[1] || (dic[i])[1] == (dic[j])[1])
                    {
                        lineMatrix[i, j] = 1;
                        lineMatrix[j, i] = 1;
                    } 
                }
            }
            /*int i = 0;
            int j = 0;
            int m = g.Edges().Count;
            int[,] lineMatrix = new int[m, m];
            foreach (int[] edge1 in g.Edges())
            {
                foreach (int[] edge2 in g.Edges())
                {
                    if (edge1[0] == edge2[0] || edge1[0] == edge2[1] || edge1[1] == edge2[0] || edge1[1] == edge2[1])
                    {
                        lineMatrix[i, j] = 1;
                        lineMatrix[j, i] = 1;
                    }
                    j++;
                }
                i++;
            }*/
            return new Graph(lineMatrix);
        }


    }
}
