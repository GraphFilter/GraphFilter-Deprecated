using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GraphFilter
{
    public static class Build
    {
        //1: num de vértices
        //2: grau máximo
        //3: grau mínimo
        //4: grau médio

        public static double Invariant(int item, Graph g)
        {
            switch (item)
            {
                case 0:
                    return 0;
                case 1:
                    return g.order;
                case 2:
                    return Degree.Max(g);
                case 3:
                    return Degree.Min(g);
                case 4:
                    return Degree.Average(g);
                default: return 0; //tratar caso em que não há escolha
            }
        }

        public static string[] ComboBox()
        {
            return new string[] {"None", "Order", "Max Degree", "Min Degree", "Avg Degree"};
        }

        #region Equation and Conditon
        public static bool Equation1(string param1, int comboInv1, string param2, int comboInv2, string param3, string relation, Graph g)
        {
            switch (relation)
            {
                case "<":
                    return Convert.ToDouble(param1) * Invariant(comboInv1, g) + Convert.ToDouble(param2) * Invariant(comboInv2, g) < Convert.ToDouble(param3);
                case "=":
                    return Convert.ToDouble(param1) * Invariant(comboInv1, g) + Convert.ToDouble(param2) * Invariant(comboInv2, g) == Convert.ToDouble(param3);
                case "<=":
                    return Convert.ToDouble(param1) * Invariant(comboInv1, g) + Convert.ToDouble(param2) * Invariant(comboInv2, g) <= Convert.ToDouble(param3);
                default: return true;
            }
        }

        public static bool Equation2(string param1, int comboInv1, int comboInv2, string param2, string relation, Graph g)
        {
            switch (relation)
            {
                case "<":
                    return Convert.ToDouble(param1) * (Invariant(comboInv1, g) / Invariant(comboInv2, g)) < Convert.ToDouble(param2);
                case "=":
                    double x = Convert.ToDouble(param2);
                    return Convert.ToDouble(param1) * (Invariant(comboInv1, g) / Invariant(comboInv2, g)) == Convert.ToDouble(param2);
                case "<=":
                    return Convert.ToDouble(param1) * (Invariant(comboInv1, g) / Invariant(comboInv2, g)) <= Convert.ToDouble(param2);
                default: return true;
            }
        }

        public static bool Equation3(string param1, int comboInv1, int comboInv2, string param2, string relation, Graph g)
        {
            switch (relation)
            {
                case "<":
                    return Convert.ToDouble(param1) * (Invariant(comboInv1, g) * Invariant(comboInv2, g)) < Convert.ToDouble(param2);
                case "=":
                    double x = Convert.ToDouble(param2);
                    return Convert.ToDouble(param1) * (Invariant(comboInv1, g) * Invariant(comboInv2, g)) == Convert.ToDouble(param2);
                case "<=":
                    return Convert.ToDouble(param1) * (Invariant(comboInv1, g) * Invariant(comboInv2, g)) <= Convert.ToDouble(param2);
                default: return true;
            }
        }
        public static bool Condition1(Graph g)
        {
            return Degree.IsRegular(g);
        }
        public static bool Condition2(Graph g, int k)
        {
            return Degree.IsRegularWithDegree(g, k);
        }
        #endregion
    }
}

