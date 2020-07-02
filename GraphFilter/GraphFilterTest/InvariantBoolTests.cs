﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private int Execute(string file, InvariantBool invariant, int k)
        {
            bool condition = false;
            int total = 0;
            int contador = 0;
            using (StreamReader stReaderIn = new StreamReader(_path + file + ".g6"))
            {
                String g6Line = stReaderIn.ReadLine();
                while (g6Line != null)
                {
                    total++;
                    if (invariant == InvariantBool.connected) condition = BuildLogic.ConditionConnected(new Graph(g6Line));
                    if (invariant == InvariantBool.disconnected) condition = !BuildLogic.ConditionConnected(new Graph(g6Line));
                    if (invariant == InvariantBool.planar) condition = BuildLogic.ConditionPlanar(new Graph(g6Line));
                    if (invariant == InvariantBool.regular) condition = BuildLogic.ConditionRegular(new Graph(g6Line));
                    if (invariant == InvariantBool.regular_k) condition = BuildLogic.ConditionRegularK(new Graph(g6Line),k);
                    if (invariant == InvariantBool.hamiltonian) condition = BuildLogic.ConditionHamiltonian(new Graph(g6Line));
                    if (invariant == InvariantBool.acyclic) condition = BuildLogic.ConditionAcyclic(new Graph(g6Line));
                    if (condition) contador++;
                    g6Line = stReaderIn.ReadLine();
                }
                return (int) 100 * (contador / total);
            }
        }
        enum InvariantBool
        {
            connected,
            disconnected,
            planar,
            regular,
            regular_k,
            hamiltonian,
            acyclic
        }

        [TestMethod()]
        public void ConnectedTEST()
        {
            /*Assert.IsTrue(Execute("connected",InvariantBool.connected, 0));
            Assert.IsTrue(Execute("disconnected", InvariantBool.disconnected, 0));*/
        }

        [TestMethod()]
        public void PlanarTEST()
        {
            Assert.AreEqual(100, Execute("planar", InvariantBool.planar, 0));
        }

        [TestMethod()]
        public void RegularTEST()
        {
            Assert.AreEqual(100, Execute("regular", InvariantBool.regular, 0));
        }

        [TestMethod()]
        public void Regular_kTEST()
        {
            Assert.AreEqual(100, Execute("regular6", InvariantBool.regular_k, 6));
            Assert.AreEqual(100, Execute("regular10", InvariantBool.regular_k, 10));
        }

        [TestMethod()]
        public void Hamiltonian_TEST()
        {
            Assert.AreEqual(100, Execute("hamiltonian", InvariantBool.hamiltonian, 0));
        }
        
        [TestMethod()]
        public void Acyclic_TEST()
        {
            Assert.AreEqual(100, Execute("girthInfinite", InvariantBool.acyclic, 0));
        }
        
    }
}
 