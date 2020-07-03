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


        public FilesFilter(Stream fileIn, String fileOut, Form1 form1)
        {
            this.fileG6In = fileIn;
            this.fileG6OutPath = fileOut;
            this.form1 = form1;

        }

        public double[] Run()
        {
            double numberOfGraphsIn = 0;
            double numberOfGraphsOut = 0;
            bool condition = true;
            using (StreamReader stReaderIn = new StreamReader(fileG6In))
            {
                using (StreamWriter stWriterOut = new StreamWriter(fileG6OutPath))
                {
                    String g6Line = stReaderIn.ReadLine();
                    while (g6Line != null)
                    {
                        if (g6Line.Length != 0 && g6Line != " ")
                        {
                            if (form1.enableEq1.Checked)
                                condition = BuildLogic.EvaluateText(form1.textEquation1.Text, new Graph(g6Line));
                            if (form1.enableEq2.Checked)
                                condition = condition && BuildLogic.EvaluateText(form1.textEquation2.Text, new Graph(g6Line));
                            if (form1.enableEq3.Checked)
                                condition = condition && BuildLogic.EvaluateText(form1.textEquation3.Text, new Graph(g6Line));
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
                                stWriterOut.WriteLine(g6Line);
                            }
                            numberOfGraphsIn++;
                            condition = true;
                            form1.progressBar.Value++;
                        }
                        g6Line = stReaderIn.ReadLine();
                    }
                }
            }
            double percentual = Math.Round((numberOfGraphsOut / numberOfGraphsIn) * 100, 2);
            return new double[3] { numberOfGraphsIn, numberOfGraphsOut, percentual };
        }
    }
}
