using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GraphFilter.GraphX;
using GraphX.Controls;
using GraphX.Controls.Models;
using GraphX.PCL.Logic.Models;
using QuickGraph;

namespace GraphFilter
{
    public class GenerateViewer
    {
        /*public GraphExample GenerateGraph(int[,] adj)
        {
            int order = adj.GetLength(0);
            var dataGraph = new GraphExample();

            for (int i = 0; i < order; i++)
            {
                var dataVertex = new DataVertex("" + i);
                dataGraph.AddVertex(dataVertex);
            }
            var vlist = dataGraph.Vertices.ToList();

            for (int i = 0; i < order; i++)
            {
                for (int j = i + 1; j < order; j++)
                {
                    if (adj[i, j] == 1)
                    {
                        var dataEdge = new DataEdge(vlist[i], vlist[j]);
                        dataGraph.AddEdge(dataEdge);
                    }
                }
            }
            return dataGraph;
        }

        /*private UIElement GenerateWpfVisual()
        {
            _zoomctrl = new ZoomControl();
            ZoomControl.SetViewFinderVisibility(_zoomctrl, Visibility.Visible);
            var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
            _gArea = new GraphAreaExample { LogicCore = logic, EdgeLabelFactory = new DefaultEdgelabelFactory()};
            _gArea.ShowAllEdgesLabels(true);
        }*/
    }
};

