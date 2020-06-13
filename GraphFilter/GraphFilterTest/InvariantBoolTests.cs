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
    public class InvariantBoolTests
    {
        private string _path = System.IO.Path.GetFullPath(@"..\..\") + "\\g6Files\\";
        bool Execute(string file, InvariantBool invariant, int k)
        {
            bool condition = false;
            using (StreamReader stReaderIn = new StreamReader(_path + file + ".g6"))
            {
                String g6Line = stReaderIn.ReadLine();
                while (g6Line != null)
                {
                    if (invariant == InvariantBool.connected) condition = BuildLogic.ConditionConnected(new Graph(g6Line));
                    if (invariant == InvariantBool.disconnected) condition = !BuildLogic.ConditionConnected(new Graph(g6Line));
                    if (invariant == InvariantBool.planar) condition = BuildLogic.ConditionPlanar(new Graph(g6Line));
                    if (invariant == InvariantBool.regular) condition = BuildLogic.ConditionRegular(new Graph(g6Line));
                    if (invariant == InvariantBool.regular_k) condition = BuildLogic.ConditionRegularK(new Graph(g6Line),k);
                    if (invariant == InvariantBool.hamiltonian) condition = BuildLogic.ConditionHamiltonian(new Graph(g6Line));
                    if (!condition) return false;
                    g6Line = stReaderIn.ReadLine();
                }
                return true;
            }
        }
        enum InvariantBool
        {
            connected,
            disconnected,
            planar,
            regular,
            regular_k,
            hamiltonian
        }

        [TestMethod()]
        public void ConnectedTEST()
        {
            Assert.IsTrue(Execute("connected",InvariantBool.connected,0));
            Assert.IsTrue(Execute("disconnected", InvariantBool.disconnected, 0));  
        }

        [TestMethod()]
        public void PlanarTEST()
        {
            Assert.IsTrue(Execute("planar", InvariantBool.planar, 0));
        }

        [TestMethod()]
        public void RegularTEST()
        {
            Assert.IsTrue(Execute("regular", InvariantBool.regular, 0));
        }

        [TestMethod()]
        public void Regular_kTEST()
        {
            Assert.IsTrue(Execute("regular6", InvariantBool.regular_k, 6));
            Assert.IsTrue(Execute("regular10", InvariantBool.regular_k, 10));
        }

        [TestMethod()]
        public void Hamiltonian_TEST()
        {
            Assert.IsTrue(Execute("hamiltonian", InvariantBool.hamiltonian, 0));
        }
    }
}
 