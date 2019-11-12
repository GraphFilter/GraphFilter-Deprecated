using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter
{
    public class Graph
    {
        public int[,] adjacencyMatrix { get; private set; }

        public int order { get; private set; }

        public List<int> sequenceDegree { get; private set; }

        public Graph(string graph6code)
        {
            adjacencyMatrix = Conversor.Graph6toAdjMatrix(graph6code);
            order = adjacencyMatrix.Rank;
            sequenceDegree = SequenceDegree();
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
            return sequenceDegree[i];
        }

        public List<int> SequenceDegree()
        {
            List<int> seqDegree = new List<int>(this.order);
            int sumRow = 0;
            for (int i = 0; i < g.order; i++)
            {
                for (int j = 0; j < g.order; j++)
                {
                    sumRow = sumRow + this.adjacencyMatrix[i, j];
                }
                seqDegree.Add(sumRow);
                sumRow = 0;
            }
            return seqDegree;
        }

        bool 3*vovm -2cmvom
    }
}
