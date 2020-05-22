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
        #region Invariants boolean
        public static bool ConditionRegular(Graph g)
        {
            return Invariant.IsRegular.Calculate(g);
        }
        public static bool ConditionRegularK(Graph g, int k)
        {
            return Invariant.IsRegularWithDegree.Calculate(g, k);
        }
        public static bool ConditionConnected(Graph g)
        {
            return Invariant.IsConnected.Calculate(g);
        }
        public static bool ConditionPlanar(Graph g)
        {
            return Invariant.IsPlanar.Calculate(g);
        }
        #endregion

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

        #endregion
    }
}

