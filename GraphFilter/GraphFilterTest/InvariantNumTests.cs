using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ComponentAce.Compression.Libs.ZLib;

namespace GraphFilter.Invariant.Tests
{
    [TestClass()]
    public class InvariantNumTests
    {
        private string _path = System.IO.Path.GetFullPath(@"..\..\")+"\\g6Files\\";
        public bool Execute(string file, string condition)
        {
            using (StreamReader stReaderIn = new StreamReader(_path+file+".g6"))
            {
                String g6Line = stReaderIn.ReadLine();
                while (g6Line != null)
                {
                    if (!BuildLogic.Text2BoolNCalc(condition, new Graph(g6Line)))
                    {
                        return false;
                    }
                    g6Line = stReaderIn.ReadLine();
                }
                return true;
            }
        }
        
        [TestMethod()]
        public void AlgebricConnectivityTEST()
        {
            Assert.IsTrue(Execute("algCon3-4", "3<="+InvariantNum.AlgebricConnectivity.getCode()+"()<=4"));
        }

        [TestMethod()]
        public void CliqueNumberTEST()
        {
            Assert.IsTrue(Execute("cliqueNumber4", InvariantNum.CliqueNumber.getCode() + "()=4"));
            Assert.IsTrue(Execute("cliqueNumber5", InvariantNum.CliqueNumber.getCode() + "()=5"));
            Assert.IsTrue(Execute("cliqueNumber7", InvariantNum.CliqueNumber.getCode() + "()=7"));
        }
        
        [TestMethod()]
        public void DiameterTEST()
        {
            Assert.IsTrue(Execute("diameter7", InvariantNum.Diameter.getCode() + "()=7"));
        }

        [TestMethod()]
        public void SpectralRadiusTEST()
        {
            Assert.IsTrue(Execute("spectralRadius5-6", "3<=" + InvariantNum.SpectralRadius.getCode() + "()<=4"));
        }


        [TestMethod()]
        public void AverageDegreeTEST()
        {
            Assert.IsTrue(Execute("averageDegree_5-6", "5<=" + InvariantNum.AverageDegree.getCode() + "()<=6"));
        }

        [TestMethod()]
        public void MinMaxDegreeTEST()
        {
            Assert.IsTrue(Execute("deltaPlusDelta10", InvariantNum.MinDegree.getCode() +"() +"+ InvariantNum.MaxDegree.getCode() + "()=10"));
        }

        [TestMethod()]
        public void NumberOfEdgesTEST()
        {
            Assert.IsTrue(Execute("numberOfEdges12", InvariantNum.NumberOfEdges.getCode() + "()=12"));
        }

        [TestMethod()]
        public void IndependenceNumberTEST()
        {
            Assert.IsTrue(Execute("independenceNumber7", InvariantNum.IndependenceNumber.getCode() + "()=7"));
        }
        
        [TestMethod()]
        public void MatchingNumberTEST()
        {
            Assert.IsTrue(Execute("matchingNumber5", InvariantNum.MatchingNumber.getCode() + "()=5"));
        }

        [TestMethod()]
        public void ChromaticNumberTEST()
        {
            Assert.IsTrue(Execute("chromaticNumber6", InvariantNum.ChromaticNumber.getCode() + "()=6"));
        }

        [TestMethod()]
        public void VertexConnectivyTEST()
        {
            Assert.IsTrue(Execute("vertexConnectivy2", InvariantNum.VerticeConnectivy.getCode() + "()=2"));
            //Assert.IsTrue(Execute("vertexConnectivy5", InvariantNum.VerticeConnectivy.getCode() + "()=5"));
        }

        [TestMethod()]//funciona somente no caso do grafo não ser acíclico
        public void GirthTEST()
        {
            Assert.IsTrue(Execute("girth4", InvariantNum.Girth.getCode() + "()=4"));
            Assert.IsTrue(Execute("girth6", InvariantNum.Girth.getCode() + "()=6"));
            Assert.IsTrue(Execute("girthInfinite", InvariantNum.Girth.getCode() + "()>100000"));
        }

        [TestMethod()]
        public void NumberOfComponentsTEST()
        {
            Assert.IsTrue(Execute("3NC", InvariantNum.NumberOfComponents.getCode() + "()=3"));
            Assert.IsTrue(Execute("5NC", InvariantNum.NumberOfComponents.getCode() + "()=5"));
            Assert.IsTrue(Execute("connected", InvariantNum.NumberOfComponents.getCode() + "()=1"));
            Assert.IsTrue(Execute("disconnected", InvariantNum.NumberOfComponents.getCode() + "()>1"));
        }

        //FALTA: energias e num de árvores geradoras
    }
}