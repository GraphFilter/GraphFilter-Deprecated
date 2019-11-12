using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter
{
    public class Graph
    {
        private int[,] adjacencyMatrix { get; set; }

        private int order { get; set; }

        public Graph(string graph6code)
        {
            adjacencyMatrix = Conversor.Graph6toAdjMatrix(graph6code);
            order = adjacencyMatrix.Rank;
        }

        public Boolean adjacent(int i, int j)
        {
            return adjacencyMatrix[i, j] == 1;
        }

        public List<int> N(int i) //neighbourhood
        {
            List<int> neighbourhood = new List<int>(order-1);
            for (int j = 0; j < order; j++)
            {
                if (adjacencyMatrix[i, j] == 1) neighbourhood.Add(j);
            }
            return neighbourhood;
        }

        public int DegreeOf(int i)
        {
            int degree = 0;
            for (int j = 0; j < order; j++)
            {
                degree = degree + adjacencyMatrix[i, j];
            }
            return degree;
        }

        bool 3*vovm -2cmvom
    }
}
