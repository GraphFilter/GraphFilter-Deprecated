using GraphFilter.Invariants;
using GraphX.Logic.Algorithms.LayoutAlgorithms;
using NCalc;
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
                    return Invariant.MaxDegree.Calculate(g);
                case 3:
                    return Invariant.MinDegree.Calculate(g);
                case 4:
                    return Invariant.AverageDegree.Calculate(g);
                case 5:
                    return Invariant.CliqueNumber.Calculate(g);
                case 6:
                    return Invariant.Diameter.Calculate(g);
                case 7:
                    return Invariant.AlgebricConnectivity.Calculate(g);
                case 8:
                    return Invariant.SpectralRadius.Calculate(g);
                case 9:
                    return Invariant.LaplacianEnergy.Calculate(g);
                case 10:
                    return Invariant.AdjacencyEnergy.Calculate(g);
                case 11:
                    return Invariant.ChromaticNumber.Calculate(g);
                case 12:
                    return Invariant.IndependenceNumber.Calculate(g);
                default: return 0; //tratar caso em que não há escolha
            }
        }
        #endregion

        #region Invariants boolean
        public static bool Condition1(Graph g)
        {
            return Invariant.IsRegular.Calculate(g);
        }
        public static bool Condition2(Graph g, int k)
        {
            return Invariant.IsRegularWithDegree.Calculate(g, k);
        }
        public static bool Condition3(Graph g)
        {
            return Invariant.IsConnected.Calculate(g);
        }
        #endregion

        public static string[] ComboBox()
        {
            return new string[] { "None", "Order", "Max Degree", "Min Degree", "Average Degree", "Clique Number", "Diameter", "Connectivity Algebraic", "Spectral Radius", "Laplacian Energy", "Adjacencý Energy", "Chromatic Number", "Independency Number" };
        }

        #region Equation and Conditon
        public static bool Text2BoolNCalc(string text, Graph g)
        {
            var ex = new NCalc.Expression(text);

            ex.EvaluateFunction += delegate (string name, FunctionArgs args)
            {
                if (name == Invariant.Order.getCode()) args.Result = Invariant.Order.Calculate(g);
                if (name == Invariant.MaxDegree.getCode()) args.Result = Invariant.MaxDegree.Calculate(g);
                if (name == Invariant.MinDegree.getCode()) args.Result = Invariant.MinDegree.Calculate(g);
                if (name == Invariant.AverageDegree.getCode()) args.Result = Invariant.AverageDegree.Calculate(g);
                if (name == Invariant.CliqueNumber.getCode()) args.Result = Invariant.CliqueNumber.Calculate(g);
                if (name == Invariant.Diameter.getCode()) args.Result = Invariant.Diameter.Calculate(g);
                if (name == Invariant.AlgebricConnectivity.getCode()) args.Result = Invariant.AlgebricConnectivity.Calculate(g);
                if (name == Invariant.SpectralRadius.getCode()) args.Result = Invariant.SpectralRadius.Calculate(g);
                if (name == Invariant.LaplacianEnergy.getCode()) args.Result = Invariant.LaplacianEnergy.Calculate(g);
                if (name == Invariant.AdjacencyEnergy.getCode()) args.Result = Invariant.AdjacencyEnergy.Calculate(g);
                if (name == Invariant.ChromaticNumber.getCode()) args.Result = Invariant.ChromaticNumber.Calculate(g);
                if (name == Invariant.IndependenceNumber.getCode()) args.Result = Invariant.IndependenceNumber.Calculate(g);
                if (name == Invariant.NumberSpanningTree.getCode()) args.Result = Invariant.NumberSpanningTree.Calculate(g);
            };

            if (ex.Evaluate().ToString() == "True") return true;

            else if (ex.Evaluate().ToString() == "False") return false;

            throw new ArgumentException();
        }


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

