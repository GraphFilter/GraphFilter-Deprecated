using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphFilter.Invariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ComponentAce.Compression.Libs.ZLib;

namespace GraphFilter.Invariants.Tests
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
        /*
        [TestMethod()]
        public void AlgebricConnectivity()
        {
            Assert.IsTrue(Execute("algCon3-4", InvariantNum.AlgebricConnectivity.getCode()+"()>3"));
            Assert.IsTrue(Execute("algCon3-4", InvariantNum.AlgebricConnectivity.getCode()+"()<4"));
            O math.net dá erro ao verificar equação, pois usa grafo com 1 vértices.
        }
        */
        [TestMethod()]
        public void CliqueNumber()
        {
            Assert.IsTrue(Execute("cliqueNumber5", InvariantNum.CliqueNumber.getCode() + "()=5"));
        }
        
        [TestMethod()]
        public void Diameter()
        {
            Assert.IsTrue(Execute("diameter7", InvariantNum.Diameter.getCode() + "()=7"));
        }

    }


}