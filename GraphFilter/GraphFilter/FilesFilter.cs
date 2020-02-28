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

        public Preloader preloader;

        public FilesFilter(Stream fileIn, String fileOut, Form1 form1, Preloader preloader)
        {
            this.fileG6In = fileIn;
            this.fileG6OutPath = fileOut;
            this.form1 = form1;
            this.preloader = preloader;

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
                        if (form1.enableEq1.Checked)
                            condition = Build.Equation1(form1.param1Eq1.Text, form1.comboInv1Eq1.SelectedIndex, form1.param2Eq1.Text, form1.comboInv2Eq1.SelectedIndex, form1.param3Eq1.Text, form1.relationEq1.Text, new Graph(g6Line));
                        if (form1.enableEq2.Checked)
                            condition = condition && Build.Equation2(form1.param1Eq2.Text, form1.comboInv1Eq2.SelectedIndex, form1.comboInv2Eq2.SelectedIndex, form1.param2Eq2.Text, form1.relationEq2.Text, new Graph(g6Line));
                        if (form1.enableEq3.Checked)
                            condition = condition && Build.Equation3(form1.param1Eq3.Text, form1.comboInv1Eq3.SelectedIndex, form1.comboInv2Eq3.SelectedIndex, form1.param2Eq3.Text, form1.relationEq3.Text, new Graph(g6Line));
                        if (condition)
                        {
                            numberOfGraphsOut++;
                            stWriterOut.WriteLine(g6Line);
                        }
                        numberOfGraphsIn++;
                        g6Line = stReaderIn.ReadLine();
                    }
                }
            }
            double percentual = Math.Round((numberOfGraphsOut / numberOfGraphsIn) * 100, 2);
            return new double[3] { numberOfGraphsIn, numberOfGraphsOut, percentual };
        }
    }
}
