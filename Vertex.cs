using System;
using System.Text;

namespace Graph
{
    class Vertex
    {
        public int Number { get; set; }
        public Vertex(int _number)
        {
            Number = _number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
