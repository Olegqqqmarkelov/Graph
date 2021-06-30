using System;
using System.Text;

namespace Graph
{
    class Edge
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex _from, Vertex _to, int _weight = 1)
        {
            From = _from;
            To = _to;
            Weight = _weight;
        }

        public override string ToString()
        {
            
            return $"({From}: {To})";
        }
    }
}
