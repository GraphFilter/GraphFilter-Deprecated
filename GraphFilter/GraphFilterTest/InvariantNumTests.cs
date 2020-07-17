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
            List<string> listg6In = File.ReadAllLines(_path + file + ".g6").ToList();
            double numberOfGraphsIn = 0;
            double numberOfGraphsOut = 0;
            foreach (string g6Line in listg6In)
            {
                if (g6Line.Length != 0 && g6Line != " ")
                {
                    if (BuildLogic.EvaluateText(condition,new Graph(g6Line))) numberOfGraphsOut++;
                    numberOfGraphsIn++;
                }
            }
            return Math.Round((double)100 * (numberOfGraphsOut / numberOfGraphsIn), 2);
        }

        public bool ExecuteOnlyTrue(string file, string condition)
        {
            List<string> listg6In = File.ReadAllLines(_path + file + ".g6").ToList();
            double numberOfGraphsIn = 0;
            foreach (string g6Line in listg6In)
            {
                if (g6Line.Length != 0 && g6Line != " ")
                {
                    if (!BuildLogic.EvaluateText(condition, new Graph(g6Line))) return false;
                    numberOfGraphsIn++;
                }
            }
            return true;
        }

        [TestMethod()]
        public void AlgebricConnectivityTEST()
        {
            var i = new AlgebricConnectivity();
            Assert.AreEqual(100,Execute("algCon3-4", "3<="+i.getCode()+ " AND "+ i.getCode() + "<= 4"));
            Assert.AreEqual(0, Execute("algCon3-4", i.getCode() + ">=5"));
        }

        public void NullityTEST() //testar
        {
            var i = new Nullity();
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
            Assert.AreEqual(10, Execute("Return10percentual", i.getCode() + "=4"));
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
            Assert.AreEqual(100, Execute("independenceNumber6", i.getCode() + "=6"));
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

        [TestMethod()]
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
            var clique = new CliqueNumber();
            var girth = new Girth();
            var radius = new SpectralRadius();
            var diam = new Diameter();
            var index = new SpectralRadius();
            var alpha = new IndependenceNumber();
            var chi = new ChromaticNumber();
            Assert.AreEqual(90, Execute("Return90percentual", ac.getCode() + "+2*" + diam.getCode() + ">=8"));
            Assert.AreEqual(100, Execute("girthMaiorIgual5", girth.getCode() + ">=5" + " OR " + alpha.getCode() + "=4"));
            Assert.IsTrue(ExecuteOnlyTrue("perfectGraphs_n7", clique.getCode() + "=" + chi.getCode()));
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
            var clique = new CliqueNumber();
            //Assert.IsTrue(ExecuteOnlyTrue("BIG_chromatic5", chi.getCode() + "=5"));
            //Assert.IsTrue(ExecuteOnlyTrue("independenceNumberMaiorIgual5", alpha.getCode() + ">=5"));
            Assert.IsTrue(ExecuteOnlyTrue("perfectGraphs_n10", clique.getCode() + "=" + chi.getCode()));


        }
        
        //FALTA: energias e num de árvores geradoras

    }
}