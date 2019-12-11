using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GraphFilter.Invariants
{
    public static class Build
    {
        //0: num de vértices
        //1: grau máximo
        //2: grau mínimo
        //3: grau médio

        public static double Invariant(int item, Graph g)
        {
            switch (item)
            {
                case 0:
                    return g.order;
                case 1:
                    return Degree.Max(g);
                case 2:
                    return Degree.Min(g);
                case 3:
                    return Degree.Average(g);
                default: return 0; //tratar caso em que não há escolha
            }
            //Seguir esse exemplo para a criação do booleano
            bool cond = 2 * Invariant(1, g) == 0;
        }

        public static string[] ComboBox()
        {
            return new string[] { "Order", "Max Degree", "Min Degree", "Avg Degree"};
        }

        public static bool Condition(string param1, int comboInv1, string param2, int comboInv2, string param3, string relation, Graph g)
        {

            switch (relation)
            {
                case "<":
                    return Convert.ToDouble(param1) * Invariant(comboInv1, g) + Convert.ToDouble(param2) * Invariant(comboInv2, g) + Convert.ToDouble(param3) < 0;
                case "=":
                    double x = Convert.ToDouble(param3);
                    return Convert.ToDouble(param1) * Invariant(comboInv1, g) + Convert.ToDouble(param2) * Invariant(comboInv2, g) + Convert.ToDouble(param3) == 0;
                case "<=":
                case "=<":
                    return Convert.ToDouble(param1) * Invariant(comboInv1, g) + Convert.ToDouble(param2) * Invariant(comboInv2, g) + Convert.ToDouble(param3) <= 0;
                default: return true;
            }
        }
    }
}

