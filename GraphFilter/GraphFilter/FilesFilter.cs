﻿using GraphFilter.Invariants;
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
                        form1.progressBar.Value++;
                        if (form1.enableEq1.Checked)
                            condition = BuildLogic.Text2BoolNCalc(form1.textEquation1.Text, new Graph(g6Line));
                        if (form1.enableEq2.Checked)
                            condition = condition && BuildLogic.Text2BoolNCalc(form1.textEquation2.Text, new Graph(g6Line));
                        if (form1.enableEq3.Checked)
                            condition = condition && BuildLogic.Text2BoolNCalc(form1.textEquation3.Text, new Graph(g6Line));
                        if (form1.enableRegular.Checked)
                            condition = condition && BuildLogic.Condition1(new Graph(g6Line));
                        if (form1.enableRegularWithK.Checked)
                            condition = condition && BuildLogic.Condition2(new Graph(g6Line), Convert.ToInt32(form1.paramRegularWithDegree.Text));
                        if (form1.enableIsConnected.Checked)
                            condition = condition && BuildLogic.Condition3(new Graph(g6Line));
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
