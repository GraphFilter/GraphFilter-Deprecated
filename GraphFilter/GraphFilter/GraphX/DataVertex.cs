using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphX;
using GraphX.PCL.Common.Models;

namespace GraphFilter.GraphX
{
    class DataVertex: VertexBase
    {
        public string Text { get; set; }

        public DataVertex() : this("") { }

        public DataVertex(string text = "")
        {
            Text = text;
        }
    }
}
