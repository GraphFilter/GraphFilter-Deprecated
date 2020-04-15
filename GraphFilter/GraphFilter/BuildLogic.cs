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
        #region Invariant Numeric
        public static double InvariantChoice(int item, Graph g)
        {
            switch (item)
            {
                case 0:
                    return 0;
                case 1:
                    return g.order;
                case 2:
                    return MaxDegree.Calculate(g);
                case 3:
                    return MinDegree.Calculate(g);
                case 4:
                    return AverageDegree.Calculate(g);
                case 5:
                    return CliqueNumber.Calculate(g);
                case 6:
                    return Diameter.Calculate(g);
                case 7:
                    return AlgebraicConnectivity.Calculate(g);
                case 8:
                    return SpectralRadius.Calculate(g);
                case 9:
                    return LaplacianEnergy.Calculate(g);
                case 10:
                    return AdjanceyEnergy.Calculate(g);
                case 11:
                    return ChromaticNumber.Calculate(g);
                case 12:
                    return IndependenceNumber.Calculate(g);
                default: return 0; //tratar caso em que não há escolha
            }
        }
        #endregion

        #region Invariants boolean
        public static bool Condition1(Graph g)
        {
            return IsRegular.Calculate(g);
        }
        public static bool Condition2(Graph g, int k)
        {
            return IsRegularWithDegree.Calculate(g, k);
        }

        public static bool Condition3(Graph g)
        {
            return IsConnected.Calculate(g);
        }
        #endregion

        public static string[] ComboBox()
        {
            return new string[] {"None", "Order", "Max Degree", "Min Degree", "Average Degree", "Clique Number", "Diameter", "Connectivity Algebraic","Spectral Radius", "Laplacian Energy", "Adjacencý Energy", "Chromatic Number", "Independency Number"};
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
        
        #endregion
    }
}

