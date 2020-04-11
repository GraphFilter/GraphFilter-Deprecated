using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yWorks.Controls.Input;
using yWorks.Geometry;
using yWorks.Graph;
using yWorks.Graph.Styles;

namespace GraphFilter.yNET
{
    public class yNET_Conv
    {
        public Form1 form1;
        public void yNetGraph(int[,] adj, Form1 form1)
        {
            this.form1 = form1;
            int order = adj.GetLength(0);
            form1.graphControl.InputMode = new GraphEditorInputMode();
            var graph = form1.graphControl.Graph;

            var edgeStyle = new PolylineEdgeStyle
            {
                SourceArrow = Arrows.None,
                TargetArrow = Arrows.None
            };

            var nodeStyle = new ShapeNodeStyle
            {
                Shape = ShapeNodeShape.Ellipse,
                Brush = Brushes.Gray,
                Pen = null
            };

            graph.NodeDefaults.Style = nodeStyle;
            graph.EdgeDefaults.Style = edgeStyle;

            List<INode> nodes = new List<INode>(order);
            Random rand = new Random();

            for (int i = 0; i < order; i++)
            {
                var node = graph.CreateNode(new RectD(rand.Next(300), rand.Next(300), 30, 30));
                graph.AddLabel(node, "" + i);
                nodes.Add(node);
            }

            for (int i = 0; i < order; i++)
                for (int j = i + 1; j < order; j++)
                    if(adj[i, j] == 1)
                    {
                        var edge1 = graph.CreateEdge(nodes.ElementAt(i), nodes.ElementAt(j));
                    }
            form1.graphControl.FitGraphBounds();
        }
    }
}
