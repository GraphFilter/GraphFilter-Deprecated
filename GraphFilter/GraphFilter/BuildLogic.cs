using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GraphFilter
{
    public static class BuildLogic
    {
        public static double InvariantChoice(int item, Graph g)
        {
            switch (item)
            {
                case 0:
                    return 0;
                case 1:
                    return g.order;
                case 2:
                    return Invariant.MaxDegree(g);
                case 3:
                    return Invariant.MinDegree(g);
                case 4:
                    return Invariant.AverageDegree(g);
                case 5:
                    return Invariant.CliqueNumber(g);
                case 6:
                    return Invariant.Diameter(g);
                case 7:
                    return Invariant.AlgebraicConnectivity(g);
                case 8:
                    return Invariant.SpectralRadius(g);
                case 9:
                    return Invariant.LaplacianEnergy(g);
                case 10:
                    return Invariant.AdjacencyEnergy(g);

                default: return 0; //tratar caso em que não há escolha
            }
        }

        public static string[] ComboBox()
        {
            return new string[] {"None", "Order", "Max Degree", "Min Degree", "Average Degree", "Clique Number", "Diameter", "Connectivity Algebraic","Spectral Radius", "Laplacian Energy", "Adjacencý Energy"};
        }

        #region Equation and Conditon
        public static bool Equation1(string param1, int comboInv1, string param2, int comboInv2, string param3, string relation, Graph g)
        {
            switch (relation)
            {
                case "<":
                    return Convert.ToDouble(param1) * InvariantChoice(comboInv1, g) + Convert.ToDouble(param2) * InvariantChoice(comboInv2, g) < Convert.ToDouble(param3);
                case "=":
                    return Convert.ToDouble(param1) * InvariantChoice(comboInv1, g) + Convert.ToDouble(param2) * InvariantChoice(comboInv2, g) == Convert.ToDouble(param3);
                case "<=":
                    return Convert.ToDouble(param1) * InvariantChoice(comboInv1, g) + Convert.ToDouble(param2) * InvariantChoice(comboInv2, g) <= Convert.ToDouble(param3);
                default: return true;
            }
        }

        public static bool Equation2(string param1, int comboInv1, int comboInv2, string param2, string relation, Graph g)
        {
            switch (relation)
            {
                case "<":
                    return Convert.ToDouble(param1) * (InvariantChoice(comboInv1, g) / InvariantChoice(comboInv2, g)) < Convert.ToDouble(param2);
                case "=":
                    double x = Convert.ToDouble(param2);
                    return Convert.ToDouble(param1) * (InvariantChoice(comboInv1, g) / InvariantChoice(comboInv2, g)) == Convert.ToDouble(param2);
                case "<=":
                    return Convert.ToDouble(param1) * (InvariantChoice(comboInv1, g) / InvariantChoice(comboInv2, g)) <= Convert.ToDouble(param2);
                default: return true;
            }
        }

        public static bool Equation3(string param1, int comboInv1, int comboInv2, string param2, string relation, Graph g)
        {
            switch (relation)
            {
                case "<":
                    return Convert.ToDouble(param1) * (InvariantChoice(comboInv1, g) * InvariantChoice(comboInv2, g)) < Convert.ToDouble(param2);
                case "=":
                    double x = Convert.ToDouble(param2);
                    return Convert.ToDouble(param1) * (InvariantChoice(comboInv1, g) * InvariantChoice(comboInv2, g)) == Convert.ToDouble(param2);
                case "<=":
                    return Convert.ToDouble(param1) * (InvariantChoice(comboInv1, g) * InvariantChoice(comboInv2, g)) <= Convert.ToDouble(param2);
                default: return true;
            }
        }
        public static bool Condition1(Graph g)
        {
            return Invariant.IsRegular(g);
        }
        public static bool Condition2(Graph g, int k)
        {
            return Invariant.IsRegular(g, k);
        }
        #endregion
    }
}

