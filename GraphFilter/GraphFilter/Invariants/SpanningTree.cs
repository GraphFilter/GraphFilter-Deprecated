using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter.Invariants
{
    public class NumberSpanningTree : Invariant
    {
        public static int Calculate(Graph g)
        {
            Matrix<double> lMatrix = DenseMatrix.OfArray(Spectral.LaplacianMatrix(g));
            lMatrix = lMatrix.RemoveColumn(g.order - 1).RemoveRow(g.order - 1);
            return (int)lMatrix.Determinant();
        }
        public static string getName() { return "number of spanning trees"; }
    }
}
