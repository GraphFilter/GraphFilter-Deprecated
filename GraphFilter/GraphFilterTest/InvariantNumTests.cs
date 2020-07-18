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
using QuickGraph;

namespace GraphFilter.Invariant.Tests
{
    
    [TestClass()]
    public class InvariantNumTests
    {
        private string _path = System.IO.Path.GetFullPath(@"..\..\..\")+"\\g6Files\\";
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

        public bool ExecuteOnlyTrue(string file, string condition)
        {
            double line = 0;
            //retorna a porcentagem (como inteiro) dos grafos que satisfazem
            using (StreamReader stReaderIn = new StreamReader(_path + file + ".g6"))
            {
                String g6Line = stReaderIn.ReadLine();
                while (g6Line != null)
                {
                    line++;
                    if (!BuildLogic.EvaluateText(condition, new Graph(g6Line))) return false;
                    g6Line = stReaderIn.ReadLine();
                }
                return true;
            }
        }

        [TestMethod()]
        public void AlgebricConnectivityTEST()
        {
            var i = new AlgebricConnectivity();
            Assert.AreEqual(100,Execute("algCon3-4", "3<="+i.getCode()+ " AND "+ i.getCode() + "<= 4"));
        }

        [TestMethod()]
        public void CliqueNumberTEST()
        {
            var i = new CliqueNumber();
            Assert.AreEqual(100, Execute("cliqueNumber4", i.getCode() + "=4"));
            Assert.AreEqual(100, Execute("cliqueNumber5", i.getCode() + "=5"));
            Assert.AreEqual(100, Execute("cliqueNumber7", i.getCode() + "=7"));
        }
        
        [TestMethod()]
        public void DiameterTEST()
        {
            var i = new Diameter();
            Assert.AreEqual(100, Execute("diameter7", i.getCode() + "=7"));
        }

        [TestMethod()]
        public void SpectralRadiusTEST()
        {
            var i = new SpectralRadius();
            Assert.AreEqual(100, Execute("spectralRadius5-6", i.getCode()+"<=6"));
        }


        [TestMethod()]
        public void AverageDegreeTEST()
        {
            var i = new AverageDegree();
            Assert.AreEqual(100, Execute("averageDegree_5-6", "5<=" + i.getCode()));
            Assert.AreEqual(100, Execute("averageDegree_5-6", i.getCode() + "<=6"));
        }

        [TestMethod()]
        public void MinMaxDegreeTEST()
        {
            var MinDegree = new MinDegree();
            var MaxDegree = new MaxDegree();
            Assert.AreEqual(100, Execute("deltaPlusDelta10", MinDegree.getCode() +"+"+ MaxDegree.getCode() + "=10"));
        }

        [TestMethod()]
        public void NumberOfEdgesTEST()
        {
            var i = new NumberOfEdges();
            Assert.AreEqual(100, Execute("numberOfEdges12", i.getCode() + "=12"));
        }

        [TestMethod()]
        public void IndependenceNumberTEST()
        {
            var i = new IndependenceNumber();
            Assert.AreEqual(100, Execute("independenceNumber7", i.getCode() + "=7"));
        }
        
        [TestMethod()]
        public void MatchingNumberTEST()
        {
            var i = new MatchingNumber();
            Assert.AreEqual(100, Execute("matchingNumber5", i.getCode() + "=5"));
        }

        [TestMethod()]
        public void ChromaticNumberTEST()
        {
            var i = new ChromaticNumber();
            Assert.AreEqual(100, Execute("chromaticNumber6", i.getCode() + "=6"));
        }

        [TestMethod()]
        public void EdgeConnectivyTEST()
        {
            var i = new EdgeConnectivy();
            Assert.AreEqual(100, Execute("edgeConnectivy4", i.getCode() + "=4"));
            Assert.AreEqual(100, Execute("disconnected", i.getCode() + "=0"));
            Assert.AreEqual(100, Execute("edgeConnectivy5", i.getCode() + "=5"));
        }

        [TestMethod()]//funciona somente no caso do grafo não ser acíclico
        public void GirthTEST()
        {
            var i = new Girth();
            var n = new Order();
            Assert.AreEqual(100, Execute("girth4", i.getCode() + "=4"));
            Assert.AreEqual(100, Execute("girth6", i.getCode() + "=6"));
            Assert.AreEqual(100, Execute("girthInfinite", i.getCode() + ">100000"));
            
        }

        [TestMethod()]
        public void NumberOfComponentsTEST()
        {
            var i = new NumberOfComponents();
            Assert.AreEqual(100, Execute("3NC", i.getCode() + "=3"));
            Assert.AreEqual(100, Execute("5NC", i.getCode() + "=5"));
            Assert.AreEqual(100, Execute("connected", i.getCode() + "=1"));
            Assert.AreEqual(100, Execute("disconnected", i.getCode() + ">1"));
        }
        
        [TestMethod()]
        public void Miscelanea()
        {
            var ec = new EdgeConnectivy();
            var ac = new AlgebricConnectivity();
            var girth = new Girth();
            var radius = new SpectralRadius();
            var diam = new Diameter();
            var index = new SpectralRadius();
            var alpha = new IndependenceNumber();
            Assert.AreEqual(90, Execute("Return90percentual", ac.getCode() + "+2*" + diam.getCode() + ">=8"));
            Assert.AreEqual(0, Execute("girth4", girth.getCode() + "=5"));
            Assert.AreEqual(10, Execute("Return10percentual", radius.getCode() + "=4"));
            Assert.AreEqual(0, Execute("algCon3-4",ac.getCode() + ">=5"));
            Assert.AreEqual(100, Execute("girthMaiorIgual5", girth.getCode() + ">=5" + " OR " + alpha.getCode() + "=4"));
            Assert.AreEqual(100, Execute("alphaMaior5_IndexMenor3", index.getCode() + "<=3"+" AND "+alpha.getCode()+">5"));

        }
        
        [TestMethod()]
        public void BigFiles()
        {
            var ec = new EdgeConnectivy();
            var ac = new AlgebricConnectivity();
            var girth = new Girth();
            var radius = new SpectralRadius();
            var diam = new Diameter();
            var index = new SpectralRadius();
            var alpha = new IndependenceNumber();
            var chi = new ChromaticNumber();
            var n = new Order();
            Assert.IsTrue(ExecuteOnlyTrue("BIG_chromatic5", chi.getCode() + "=5"));
            //Assert.IsTrue(ExecuteOnlyTrue("BIG_chromatic5(1)", chi.getCode() + "==5"));
            //Assert.IsTrue(ExecuteOnlyTrue("BIG_chromatic5(1)", n.getCode() + "=23"));
            //Assert.IsTrue(ExecuteOnlyTrue("independenceNumberMaiorIgual5", alpha.getCode() + ">=5"));
            

        }
        
        //FALTA: energias e num de árvores geradoras

    }
}