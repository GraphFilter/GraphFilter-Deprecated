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
            return InvariantBool.IsRegular.Calculate(g);
        }
        public static bool ConditionRegularK(Graph g, int k)
        {
            return InvariantBool.IsRegularWithDegree.Calculate(g, k);
        }
        public static bool ConditionConnected(Graph g)
        {
            return InvariantBool.IsConnected.Calculate(g);
        }
        public static bool ConditionPlanar(Graph g)
        {
            return InvariantBool.IsPlanar.Calculate(g);
        }

        public static bool ConditionHamiltonian(Graph g)
        {
            return InvariantBool.IsHamiltonian.Calculate(g);
        }
        #endregion

        #region Equation and Conditon
        public static bool Text2BoolNCalc(string text, Graph g)
        {
            var ex = new NCalc.Expression(text);

            ex.EvaluateFunction += delegate (string name, FunctionArgs args)
            {
                if (name == InvariantNum.Order.getCode()) args.Result = InvariantNum.Order.Calculate(g);
                if (name == InvariantNum.MaxDegree.getCode()) args.Result = InvariantNum.MaxDegree.Calculate(g);
                if (name == InvariantNum.MinDegree.getCode()) args.Result = InvariantNum.MinDegree.Calculate(g);
                if (name == InvariantNum.AverageDegree.getCode()) args.Result = InvariantNum.AverageDegree.Calculate(g);
                if (name == InvariantNum.CliqueNumber.getCode()) args.Result = InvariantNum.CliqueNumber.Calculate(g);
                if (name == InvariantNum.Diameter.getCode()) args.Result = InvariantNum.Diameter.Calculate(g);
                if (name == InvariantNum.AlgebricConnectivity.getCode()) args.Result = InvariantNum.AlgebricConnectivity.Calculate(g);
                if (name == InvariantNum.SpectralRadius.getCode()) args.Result = InvariantNum.SpectralRadius.Calculate(g);
                if (name == InvariantNum.LaplacianEnergy.getCode()) args.Result = InvariantNum.LaplacianEnergy.Calculate(g);
                if (name == InvariantNum.AdjacencyEnergy.getCode()) args.Result = InvariantNum.AdjacencyEnergy.Calculate(g);
                if (name == InvariantNum.ChromaticNumber.getCode()) args.Result = InvariantNum.ChromaticNumber.Calculate(g);
                if (name == InvariantNum.IndependenceNumber.getCode()) args.Result = InvariantNum.IndependenceNumber.Calculate(g);
                if (name == InvariantNum.NumberSpanningTree.getCode()) args.Result = InvariantNum.NumberSpanningTree.Calculate(g);
                if (name == InvariantNum.NumberOfEdges.getCode()) args.Result = InvariantNum.NumberOfEdges.Calculate(g);
                if (name == InvariantNum.MatchingNumber.getCode()) args.Result = InvariantNum.MatchingNumber.Calculate(g);
            };

            if (ex.Evaluate().ToString() == "True") return true;

            else if (ex.Evaluate().ToString() == "False") return false;

            throw new ArgumentException();
        }

        #endregion
    }
}

