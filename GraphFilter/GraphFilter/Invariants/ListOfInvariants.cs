using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public static class ListOfInvariants
    {
        //0: num de vértices
        //1: grau máximo
        //2: grau mínimo
        //3: grau médio
        
        public static double InvariantPosition( int item, Graph g)
        {
            switch (item)
            {
                case 0:
                    return g.order;
                    break;
                case 1:
                    return Degree.Max(g);
                    break;
                case 2:
                    return Degree.Min(g);
                    break;
                case 3:
                    return Degree.Average(g);
                    break;
                default: return 0; //tratar caso em que não há escolha
                    break;
            }
        }
    }
}
