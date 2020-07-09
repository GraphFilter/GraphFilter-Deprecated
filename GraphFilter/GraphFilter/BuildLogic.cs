﻿using Flee.PublicTypes;
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

