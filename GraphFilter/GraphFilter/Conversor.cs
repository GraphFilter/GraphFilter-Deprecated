﻿using GraphFilter.GraphX_Utils;
using System;
using System.Linq;


namespace GraphFilter
{
    public static class Conversor
    {
        public static int[,] Graph6toAdjMatrix(string g6)
        {
            //leitura apenas para grafos com até 258.047 vértices.
            string R_x = "";
            string bin6 = "";

            if (g6.Length == 0) return new int[0, 0];
            int n;
            if (g6.ElementAt(0) == 126)
            {
                if (g6.ElementAt(1) == 126) return null; //n>258.047
                n = Convert.ToInt32(Conversor.Rx(1, 3, g6), 2);
                R_x = Conversor.Rx(4, g6.Length - 1, g6);
            }
            else {
                n = g6.ElementAt(0) - 63;
                R_x = Conversor.Rx(1, g6.Length - 1, g6);
            }
            //string x = R_x.Substring(0, (n * (n - 1)) / 2);
            int[,] AdjMatrix = new int[n, n];
            
            int k = 0;
            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    AdjMatrix[i, j] = Convert.ToInt32(R_x.Substring(k, 1));
                    AdjMatrix[j, i] = Convert.ToInt32(R_x.Substring(k, 1));
                    k++;
                }
                AdjMatrix[j, j] = 0;
            }
            AdjMatrix[0, 0] = 0;
            return AdjMatrix;
        }

        private static String Rx(int init, int end, string g6)
        {
            string bin6 = "";
            string R_x = "";

            for (int i = init; i <= end; i++)
            {
                bin6 = DecimalToBinary(Convert.ToInt32(g6.ElementAt(i) - 63));
                while (bin6.Length < 6) { bin6 = "0" + bin6; };
                R_x = R_x + bin6;
                
            }
            return R_x;
        }

        /*
         * if (g6.Length == 0) return new int[0, 0];
            int n = 0;
            if (g6.ElementAt(0) >= 126)
                n = 126;
            else
                n = g6.ElementAt(0) - 63;

            string R_x = "";
            string bin6 = "";

            for (int i = 1; i < g6.Length; i++)
            {
                bin6 = DecimalToBinary(Convert.ToInt32(g6.ElementAt(i) - 63));
                while (bin6.Length < 6) { bin6 = "0" + bin6; };
                R_x = R_x + bin6;
            }

            string x = R_x.Substring(0, (n * (n - 1)) / 2);

            int[,] AdjMatrix = new int[n, n];
            int k = 0;
            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    AdjMatrix[i, j] = Convert.ToInt32(x.Substring(k, 1));
                    AdjMatrix[j, i] = Convert.ToInt32(x.Substring(k, 1));
                    k++;
                }
                AdjMatrix[j, j] = 0;

            }
            AdjMatrix[0, 0] = 0;

            return AdjMatrix;*/

        private static string DecimalToBinary(int decimalNumber)
        {
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            return result;

        }

        /*public static QuickGraph.AdjacencyGraph<int, QuickGraph.Edge<int>> GraphToAdjacencyQuickGraph(Graph g)
        {
            var graph = new QuickGraph.AdjacencyGraph<int, QuickGraph.Edge<int>>();
            QuickGraph.Edge<int>[] edges = new QuickGraph.Edge<int>[g.order];
            for (int i = 0; i < g.order; i++)
            {
                for (int j = i + 1; j < g.order; j++)
                {
                    if (g.adjacencyMatrix[i, j] == 1) graph.AddEdge(new QuickGraph.Edge<int>(i, j));
                }
            }
            EdmondsKarpMaximumFlowAlgorithm<int, QuickGraph.Edge<int>>()

            return graph;
        }*/



        public static CreateGraph G6toQuickGraph(string g6)
        {
            int[,] adjMatrix = Graph6toAdjMatrix(g6);
            var graph = new CreateGraph();
            int order = adjMatrix.GetLength(0);

            //Create vertices
            for (int i = 0; i < order; i++)
            {
                var vertex = new DataVertex("" + i);
                graph.AddVertex(vertex);
            }

            var vlist = graph.Vertices.ToList();

            //Create edges of graph g

            for (int i = 0; i < order; i++)
                for (int j = i + 1; j < order; j++)
                    if (adjMatrix[i, j] == 1)
                    {
                        var edge = new DataEdge(vlist[i], vlist[j]);
                        var edge1 = new DataEdge(vlist[j], vlist[i]);
                        graph.AddEdge(edge);
                        graph.AddEdge(edge1);
                    }
            return graph;
        }
        
        /*
        public static string GraphToGraph6(int[,] adjMatrix)
        {
            int n = adjMatrix.Rank;
            string block6 = ""; //variável auxiliar para tratar cada código binário de 6 dígitos
            string NtoASCII = ""; //armazena o número de vértices em ASCII
            string adjVector_binary = ""; //armazena código binário da matriz de adjacência
            string adjVector_ASCII = ""; //armazena código binário da matriz de adjacência

            //construção de NemASCII
            string nBinary = DecimalToBinary(n); //converte n para binário
            while (nBinary.Length % 6 != 0) nBinary = "0" + nBinary; //insere 0 à esquerda até obter código binário com tamanho múltiplo de 6
            for (int i = 0; i < nBinary.Length; i = i + 6) //transforma cada bloco de 6 em um ASC II
            {
                block6 = nBinary.Substring(i, 6);
                NtoASCII = NtoASCII + Convert.ToChar((Convert.ToInt32(block6, 2) + 63)).ToString();
            }

            //construção do vetorAdjanceciaEmASCII

            //ordem do passeio na matriz ((0,1),(0,2),(1,2),(0,3),(1,3),(2,3),(0,4),(1,4),(2,4),(3,4),(0,5),...,(n-2,n-1).
            int rown = 0;
            int column = 1;
            do
            {
                if (n < 3) break;
                adjVector_binary = adjVector_binary + adjMatrix[rown, column].ToString();
                if (rown == column - 1)
                {
                    rown = 0;
                    column = column + 1;
                }
                else rown = rown + 1;
            } while (rown < n - 1 && column < n);

            while (adjVector_binary.Length % 6 != 0) adjVector_binary = adjVector_binary + "0";


            for (int i = 0; i < adjVector_binary.Length; i = i + 6)
            {
                block6 = adjVector_binary.Substring(i, 6);
                adjVector_ASCII = adjVector_ASCII + Convert.ToChar((Convert.ToInt32(block6, 2) + 63)).ToString();
            }

            return NtoASCII + adjVector_ASCII;
        }
        */

    }
}
