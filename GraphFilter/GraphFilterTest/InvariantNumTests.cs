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
        private string _path = System.IO.Path.GetFullPath(@"..\..\")+"\\g6Files\\";
        EdgeConnectivy ec = new EdgeConnectivy();
        AlgebricConnectivity ac = new AlgebricConnectivity();
        Girth girth = new Girth();
        Diameter diam = new Diameter();
        Eigen1Adjacency lambda1 = new Eigen1Adjacency();
        Eigen2Adjacency lambda2 = new Eigen2Adjacency();
        Eigen1Laplacian mu1 = new Eigen1Laplacian();
        Eigen2Laplacian mu2 = new Eigen2Laplacian();
        IndependenceNumber alpha = new IndependenceNumber();
        CliqueNumber omega = new CliqueNumber();
        AverageDegree avdeg = new AverageDegree();
        MinDegree minDeg = new MinDegree();
        MaxDegree maxDeg = new MaxDegree();
        NumberOfEdges m = new NumberOfEdges();
        MatchingNumber Mx = new MatchingNumber();
        NumberOfComponents nc = new NumberOfComponents();
        NumberSpanningTree spnt = new NumberSpanningTree();
        Nullity nul = new Nullity();
        Order n = new Order();

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
                    if (!BuildLogic.EvaluateText(condition, new Graph(g6Line)))
                    {
                        return false;
                    }
                    g6Line = stReaderIn.ReadLine();
                }
                return true;
            }
        }

        [TestMethod()]
        public void Spectral()
        {
            Assert.IsTrue(ExecuteOnlyTrue("algCon3-4", "3<="+ac.getCode()+ "_G AND " + ac.getCode() + "_G<= 4"));
            Assert.IsTrue(ExecuteOnlyTrue("spectralRadius5-6", lambda1.getCode() + "_G<=6"));
            Assert.IsTrue(ExecuteOnlyTrue("trees_n14", nul.getCode() + "_G = " + n.getCode() + "_G-2*" + Mx.getCode() + "_G"));

        }

        [TestMethod()]
        public void CliqueNumber()
        {
            Assert.IsTrue(ExecuteOnlyTrue("cliqueNumber4", omega.getCode() + "_G=4"));
            Assert.IsTrue(ExecuteOnlyTrue("cliqueNumber5", omega.getCode() + "_G=5"));
            Assert.IsTrue(ExecuteOnlyTrue("cliqueNumber7", omega.getCode() + "_G=" + alpha.getCode() + "_cG"));
        }
        
        [TestMethod()]
        public void Diameter()
        {
            Assert.IsTrue(ExecuteOnlyTrue("diameter7", diam.getCode() + "_G=7"));
        }


        [TestMethod()]
        public void AverageDegree()
        {
            Assert.IsTrue(ExecuteOnlyTrue("averageDegree_5-6", "5<=" + avdeg.getCode()+ "_G"));
            Assert.IsTrue(ExecuteOnlyTrue("averageDegree_5-6", avdeg.getCode() + "_G<=6"));
        }

        [TestMethod()]
        public void MinMaxDegree()
        {
            Assert.IsTrue(ExecuteOnlyTrue("deltaPlusDelta10", minDeg.getCode() +"_G+"+ maxDeg.getCode() + "_G=10"));
        }

        [TestMethod()]
        public void NumberOfEdges()
        {
            Assert.IsTrue(ExecuteOnlyTrue("numberOfEdges12", m.getCode() + "_G=12"));
        }

        [TestMethod()]
        public void IndependenceNumber()
        {
            Assert.IsTrue(ExecuteOnlyTrue("independenceNumber7", alpha.getCode() + "_G=7"));
        }
        
        [TestMethod()]
        public void MatchingNumber()
        {
            Assert.IsTrue(ExecuteOnlyTrue("matchingNumber5", Mx.getCode() + "_G=5"));
            Assert.IsTrue(ExecuteOnlyTrue("all_graph8", Mx.getCode() + "_G="+ alpha.getCode()+"_lG"));
        }

        /*[TestMethod()]
        public void ChromaticNumber()
        {
            var i = new ChromaticNumber();
            Assert.AreEqual(100, Execute("chromaticNumber6", i.getCode() + "=6"));
        }*/

        [TestMethod()]
        public void EdgeConnectivy()
        {
            Assert.IsTrue(ExecuteOnlyTrue("edgeConnectivy4", ec.getCode() + "_G=4"));
            Assert.IsTrue(ExecuteOnlyTrue("disconnected", ec.getCode() + "_G=0"));
            Assert.IsTrue(ExecuteOnlyTrue("edgeConnectivy5", ec.getCode() + "_G=5"));
        }

        [TestMethod()]
        public void Girth()
        {

            Assert.IsTrue(ExecuteOnlyTrue("girth4", girth.getCode() + "_G=4"));
            Assert.IsTrue(ExecuteOnlyTrue("girth6", girth.getCode() + "_G=6"));
            Assert.IsTrue(ExecuteOnlyTrue("girthInfinite", girth.getCode() + "_G>100000"));
            
        }

        [TestMethod()]
        public void NumberOfComponents()
        {
            Assert.IsTrue(ExecuteOnlyTrue("3NC", nc.getCode() + "_G=3"));
            Assert.IsTrue(ExecuteOnlyTrue("5NC", nc.getCode() + "_G=5"));
            Assert.IsTrue(ExecuteOnlyTrue("connected", nc.getCode() + "_G=1"));
            Assert.IsTrue(ExecuteOnlyTrue("disconnected", nc.getCode() + "_G>1"));
        }

        [TestMethod()]
        public void NumberOfSpnTrees()
        {
            var i = new NumberSpanningTree();
            Assert.IsTrue(ExecuteOnlyTrue("trees_n14", spnt.getCode() + "_G=1"));
        }


        [TestMethod()]
        public void Miscelanea()
        {
            Assert.IsTrue(ExecuteOnlyTrue("all_graph8", mu2.getCode() + "_G+" + mu2.getCode() + "_cG<=2*" + n.getCode() + "_G-2"));//conjecture GRIJO
            Assert.AreEqual(90, Execute("Return90percentual", ac.getCode() + "_G+2*" + diam.getCode() + "_G>=8"));
            Assert.AreEqual(0, Execute("girth4", girth.getCode() + "_G=5"));
            Assert.AreEqual(10, Execute("Return10percentual", lambda1.getCode() + "_G=4"));
            Assert.AreEqual(0, Execute("algCon3-4",ac.getCode() + "_G>=5"));
            Assert.AreEqual(100, Execute("girthMaiorIgual5", girth.getCode() + "_G>=5" + " OR " + alpha.getCode() + "_G=4"));
            //Assert.AreEqual(100, Execute("alphaMaior5_IndexMenor3", lambda1.getCode() + "_G<=3" + " AND "+alpha.getCode()+ "_G>5"));
            
        }
        
        [TestMethod()]
        public void BigFiles()
        {
            //var chi = new ChromaticNumber();
            //Assert.IsTrue(ExecuteOnlyTrue("BIG_chromatic5", chi.getCode() + "_G=5")); 
            //Assert.IsTrue(ExecuteOnlyTrue("independenceNumberMaiorIgual5", alpha.getCode() + "_G>=5"));


        }



        //FALTA: energias e num de árvores geradoras

    }
}