using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public class MaxDegree : Invariant
    {
        public static int Calculate(Graph g) {return g.sequenceDegree.Max();}
        public static string getName() {return "Max Degree";}

    }

    public class MinDegree : Invariant
    {
        public static int Calculate(Graph g) {return g.sequenceDegree.Min();}
        public static string getName() {return "Min Degree";}
    }

    public class AverageDegree : Invariant
    {
        public static double Calculate(Graph g)
        {
            return g.sequenceDegree.Average();
        }
        public static string getName(){return "Average Degree";}
    }

    public class IsRegular : Invariant
    {
        public static bool Calculate(Graph g)
        {
            for (int i = 0; i < g.order - 1; i++)
            {
                if (g.sequenceDegree.ElementAt<int>(i) != g.sequenceDegree.ElementAt<int>(i + 1)) return false;
            }
            return true;
        }
        public static string getName() { return "Is a regular graph"; }
    }

    public class IsRegularWithDegree : Invariant
    {
        public static bool Calculate(Graph g, int k)
        {
            for (int i = 0; i < g.order - 1; i++)
            {
                if (g.sequenceDegree.ElementAt<int>(i) != k) return false;
            }
            return true;
        }
        public static string getName() {return "Is a regular graph with degree k";}
    }
}
