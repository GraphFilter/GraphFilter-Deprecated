using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphFilter
{
    public class FilesFilter
    {
        public Stream fileG6In { get; private set; }
        public String fileG6OutPath { get; private set; }

        public Form1 form1;
        public List<string> Listg6In { get; private set; }


        public FilesFilter(List<string> listg6In, String fileOut, Form1 form1)
        {
            this.fileG6OutPath = fileOut;
            this.form1 = form1;
            this.Listg6In = listg6In;
        }

        public double[] Run()
        {
            double numberOfGraphsIn = 0;
            double numberOfGraphsOut = 0;
            bool condition = true;
            string g6Final = "";
            string g6Actual = "";

            foreach (string g6Line in Listg6In)
            {
                if (g6Line.Length != 0 && g6Line != " ")
                {
                    if (form1.enableEq1.Checked)
                        condition = BuildLogic.EvaluateText(form1.textEquation1.Text, new Graph(g6Line));
                    if (form1.enableRegular.Checked)
                        condition = condition && BuildLogic.ConditionRegular(new Graph(g6Line));
                    if (form1.enableRegularWithK.Checked)
                        condition = condition && BuildLogic.ConditionRegularK(new Graph(g6Line), Convert.ToInt32(form1.paramRegularWithDegree.Text));
                    if (form1.enableIsConnected.Checked)
                        condition = condition && BuildLogic.ConditionConnected(new Graph(g6Line));
                    if (form1.enableIsPlanar.Checked)
                        condition = condition && BuildLogic.ConditionPlanar(new Graph(g6Line));
                    if (form1.enableIsHamiltonian.Checked)
                        condition = condition && BuildLogic.ConditionHamiltonian(new Graph(g6Line));
                    if (form1.enableIsAcyclic.Checked)
                        condition = condition && BuildLogic.ConditionAcyclic(new Graph(g6Line));
                    if (condition)
                    {
                        numberOfGraphsOut++;
                        g6Actual = g6Actual + g6Line + "\n";
                        g6Final = g6Actual;
                    }
                    numberOfGraphsIn++;
                    condition = true;
                    form1.progressBar.Value++;
                }
            } 

            using (StreamWriter sw = new StreamWriter(fileG6OutPath))
            {
                sw.Write(g6Final);
            }
            double percentual = Math.Round((numberOfGraphsOut / numberOfGraphsIn) * 100, 2);
            return new double[3] { numberOfGraphsIn, numberOfGraphsOut, percentual };
        }
    }
}
