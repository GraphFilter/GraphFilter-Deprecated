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
                    return AlgebricConnectivity.Calculate(g);
                case 8:
                    return SpectralRadius.Calculate(g);
                case 9:
                    return LaplacianEnergy.Calculate(g);
                case 10:
                    return AdjacencyEnergy.Calculate(g);
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
            return new string[] { "None", "Order", "Max Degree", "Min Degree", "Average Degree", "Clique Number", "Diameter", "Connectivity Algebraic", "Spectral Radius", "Laplacian Energy", "Adjacencý Energy", "Chromatic Number", "Independency Number" };
        }

        #region Equation and Conditon
        public static bool Text2BoolNCalc(string text, Graph g)
        {
            var ex = new NCalc.Expression(text);

            ex.EvaluateFunction += delegate (string name, FunctionArgs args)
            {
                if (name == Order.getCode()) args.Result = Order.Calculate(g);
                if (name == MaxDegree.getCode()) args.Result = MaxDegree.Calculate(g);
                if (name == MinDegree.getCode()) args.Result = MinDegree.Calculate(g);
                if (name == AverageDegree.getCode()) args.Result = AverageDegree.Calculate(g);
                if (name == CliqueNumber.getCode()) args.Result = CliqueNumber.Calculate(g);
                if (name == Diameter.getCode()) args.Result = Diameter.Calculate(g);
                if (name == AlgebricConnectivity.getCode()) args.Result = AlgebricConnectivity.Calculate(g);
                if (name == SpectralRadius.getCode()) args.Result = SpectralRadius.Calculate(g);
                if (name == LaplacianEnergy.getCode()) args.Result = LaplacianEnergy.Calculate(g);
                if (name == AdjacencyEnergy.getCode()) args.Result = AdjacencyEnergy.Calculate(g);
                if (name == ChromaticNumber.getCode()) args.Result = ChromaticNumber.Calculate(g);
                if (name == IndependenceNumber.getCode()) args.Result = IndependenceNumber.Calculate(g);
                if (name == NumberSpanningTree.getCode()) args.Result = NumberSpanningTree.Calculate(g);
            };

            try
            {
                if (ex.Evaluate().ToString() == "True") return true;

                else if (ex.Evaluate().ToString() == "False") return false;
            }
            catch (ArgumentException)
            {

                System.Windows.Forms.MessageBox.Show("Invalid Function!");
            }
            finally
            {
            }
            return false;
            //Escrever tratamento de erro para funções inválidas
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

