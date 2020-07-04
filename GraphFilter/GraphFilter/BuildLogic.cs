using Flee.PublicTypes;
using GraphFilter.Invariants;
using System;



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
            bool x = InvariantBool.IsConnected.Calculate(g);
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

        public static bool ConditionAcyclic(Graph g)
        {
            return InvariantBool.IsAcyclic.Calculate(g);
        }
        #endregion

        #region Equation and Conditon
        public static bool EvaluateText(string text, Graph g)
        {
            //uso do pacote Flee para converter texto em lógica matemática
            /*var ex = new NCalc.Expression(text);

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
                if (name == InvariantNum.EdgeConnectivy.getCode()) args.Result = InvariantNum.EdgeConnectivy.Calculate(g);
                if (name == InvariantNum.Girth.getCode()) args.Result = InvariantNum.Girth.Calculate(g);
                if (name == InvariantNum.NumberOfComponents.getCode()) args.Result = InvariantNum.NumberOfComponents.Calculate(g);
            };
            if (ex.Evaluate().ToString() == "True" || ex.Evaluate().ToString() == "true") return true;
            if (ex.Evaluate().ToString() == "False" || ex.Evaluate().ToString() == "false") return false;

            throw new ArgumentException();*/
            ExpressionContext context = new ExpressionContext();
            VariableCollection variables = context.Variables;

            foreach (IInvariant invariant in InvariantNum.List())
            {
                if (text.Contains(invariant.getCode())) context.Variables[invariant.getCode()] = invariant.Calculate(g);
            }
            IGenericExpression<bool> e = context.CompileGeneric<bool>(text);
            return e.Evaluate();
            
            
            throw new ArgumentException();

        }


        #endregion
    }
}

