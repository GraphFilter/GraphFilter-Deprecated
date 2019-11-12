using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GraphFilter.Invariants
{
    public static class BuildEquation
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

        public static bool Condition(double param1, int comboInv1, double param2, int comboInv2, double param3, string relation, Graph g)
        {
            switch (relation)
            {
                case "<":
                    return param1 * Invariant(comboInv1, g) + param2 * Invariant(comboInv2, g) + param3 < 0;
                default: return true;
        }

            Form1 fm = new Form1();





    }
}
