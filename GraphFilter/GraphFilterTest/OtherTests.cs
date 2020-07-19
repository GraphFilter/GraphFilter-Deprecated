using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GraphFilter.Tests
{
    [TestClass()]
    public class OtherTests
    {
        public string ReadG6fromMatFiles(string file)
        {
            string path = System.IO.Path.GetFullPath(@"..\..\") + "\\g6Matrix\\";
            using (StreamReader stReaderIn = new StreamReader(path + file)) return stReaderIn.ReadLine();
        }

        public static int[,] matFile2Matrix(string file)
        {
            string path = System.IO.Path.GetFullPath(@"..\..\") + "\\g6Matrix\\";
            using (StreamReader stReaderIn = new StreamReader(path + file))
            {
                String line = stReaderIn.ReadLine();
                int[,] adjMatrix = new int[(line.Length / 2) + 1, (line.Length / 2) + 1];

                int i = 0;
                int j = 0;
                while (line != null)
                {
                    for (int k = 0; k < line.Length; k += 2)
                    {
                        adjMatrix[i, j] = line[k] - 48;
                        j++;
                    }
                    j = 0;
                    line = stReaderIn.ReadLine();
                    i++;
                }
                return adjMatrix;
            }
        }

        [TestMethod()]
        public void matFile2MatrixTest()
        {
            List<string> testFiles = new List<string>() { "n63", "n1", "n20", "n50", "n62", "n62", "n63", "n64", "n171", "n200", "n231" };
            foreach (string file in testFiles)
            {
                int[,] matrixFromMatFile = matFile2Matrix(file+".mat");
                int[,] matrixFromG6 = new Graph(ReadG6fromMatFiles(file+".g6")).adjacencyMatrix;
                CollectionAssert.AreEqual(matrixFromMatFile, matrixFromG6);
            }
            
        }

        [TestMethod()]
        public void EvaluateTextTest()
        {
            List<string> testFiles = new List<string>() { "n63", "n1", "n20", "n50", "n62", "n62", "n63", "n64", "n171", "n200", "n231" };
            foreach (string file in testFiles)
            {
                int[,] matrixFromMatFile = matFile2Matrix(file + ".mat");
                int[,] matrixFromG6 = new Graph(ReadG6fromMatFiles(file + ".g6")).adjacencyMatrix;
                CollectionAssert.AreEqual(matrixFromMatFile, matrixFromG6);
            }

        }




    }
}