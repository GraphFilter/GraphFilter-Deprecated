using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ComponentAce.Compression.Libs.ZLib;
using System.Reflection;

namespace GraphFilter.Invariant.Tests
{
    [TestClass()]
    public class InvariantNumTests
    {
        private string _path = System.IO.Path.GetFullPath(@"..\..\")+"\\g6Files\\";
        public double Execute(string file, string condition)
        {
            double total = 0;
            double contador = 0;
            //retorna a porcentagem (como inteiro) dos grafos que satisfazem
            using (StreamReader stReaderIn = new StreamReader(_path+file+".g6"))
            {
                String g6Line = stReaderIn.ReadLine();
                while (g6Line != null)
                {
                    total++;
                    if (BuildLogic.EvaluateText(condition, new Graph(g6Line))) contador++;
                    g6Line = stReaderIn.ReadLine();
                }              
                return Math.Round((double) 100*(contador / total),2);
            }
        }
        
        [TestMethod()]
        public void AlgebricConnectivityTEST()
        {
            Assert.AreEqual(100,Execute("algCon3-4", "3<="+InvariantNum.AlgebricConnectivity.getCode()+ "()<=4"));
        }

        [TestMethod()]
        public void CliqueNumberTEST()
        {
            Assert.AreEqual(100, Execute("cliqueNumber4", InvariantNum.CliqueNumber.getCode() + "()=4"));
            Assert.AreEqual(100, Execute("cliqueNumber5", InvariantNum.CliqueNumber.getCode() + "()=5"));
            Assert.AreEqual(100, Execute("cliqueNumber7", InvariantNum.CliqueNumber.getCode() + "()=7"));
        }
        
        [TestMethod()]
        public void DiameterTEST()
        {
            Assert.AreEqual(100, Execute("diameter7", InvariantNum.Diameter.getCode() + "()=7"));
        }

        [TestMethod()]
        public void SpectralRadiusTEST()
        {
            Assert.AreEqual(100, Execute("spectralRadius5-6", "3<=" + InvariantNum.SpectralRadius.getCode() + "()<=4"));
        }


        [TestMethod()]
        public void AverageDegreeTEST()
        {
            Assert.AreEqual(100, Execute("averageDegree_5-6", "5<=" + InvariantNum.AverageDegree.getCode() + "()<=6"));
        }

        [TestMethod()]
        public void MinMaxDegreeTEST()
        {
            Assert.AreEqual(100, Execute("deltaPlusDelta10", InvariantNum.MinDegree.getCode() +"() +"+ InvariantNum.MaxDegree.getCode() + "()=10"));
        }

        [TestMethod()]
        public void NumberOfEdgesTEST()
        {
            Assert.AreEqual(100, Execute("numberOfEdges12", InvariantNum.NumberOfEdges.getCode() + "()=12"));
        }

        [TestMethod()]
        public void IndependenceNumberTEST()
        {
            Assert.AreEqual(100, Execute("independenceNumber7", InvariantNum.IndependenceNumber.getCode() + "()=7"));
        }
        
        [TestMethod()]
        public void MatchingNumberTEST()
        {
            Assert.AreEqual(100, Execute("matchingNumber5", InvariantNum.MatchingNumber.getCode() + "()=5"));
        }

        [TestMethod()]
        public void ChromaticNumberTEST()
        {
            Assert.AreEqual(100, Execute("chromaticNumber6", InvariantNum.ChromaticNumber.getCode() + "()=6"));
        }

        [TestMethod()]
        public void EdgeConnectivyTEST()
        {
            Assert.AreEqual(100, Execute("edgeConnectivy4", InvariantNum.EdgeConnectivy.getCode() + "()=4"));
            Assert.AreEqual(100, Execute("disconnected", InvariantNum.EdgeConnectivy.getCode() + "()=0"));
            Assert.AreEqual(100, Execute("edgeConnectivy5", InvariantNum.EdgeConnectivy.getCode() + "()=5"));
        }

        [TestMethod()]//funciona somente no caso do grafo não ser acíclico
        public void GirthTEST()
        {
            Assert.AreEqual(100, Execute("girth4", InvariantNum.Girth.getCode() + "()=4"));
            Assert.AreEqual(100, Execute("girth6", InvariantNum.Girth.getCode() + "()=6"));
            Assert.AreEqual(100, Execute("girthInfinite", InvariantNum.Girth.getCode() + "()>100000"));
            

        }

        [TestMethod()]
        public void NumberOfComponentsTEST()
        {
            Assert.AreEqual(100, Execute("3NC", InvariantNum.NumberOfComponents.getCode() + "()=3"));
            Assert.AreEqual(100, Execute("5NC", InvariantNum.NumberOfComponents.getCode() + "()=5"));
            Assert.AreEqual(100, Execute("connected", InvariantNum.NumberOfComponents.getCode() + "()=1"));
            Assert.AreEqual(100, Execute("disconnected", InvariantNum.NumberOfComponents.getCode() + "()>1"));
        }

        [TestMethod()]
        public void Miscelanea()
        {
           //Assert.AreEqual(50, Execute("Return50percentual", InvariantNum.Diameter.getCode() +"()+" +InvariantNum.EdgeConnectivy.getCode()+ "()=5"));
            Assert.AreEqual(90, Execute("Return90percentual", InvariantNum.AlgebricConnectivity.getCode() + "()+2*" + InvariantNum.Diameter.getCode() + "()>=8"));
            Assert.AreEqual(0, Execute("girth4", InvariantNum.Girth.getCode() + "()=5"));
            Assert.AreEqual(10, Execute("Return10percentual", InvariantNum.SpectralRadius.getCode() + "()=4"));
            Assert.AreEqual(0, Execute("algCon3-4",InvariantNum.AlgebricConnectivity.getCode() + "()>=5"));
        }

        //FALTA: energias e num de árvores geradoras
    }
}