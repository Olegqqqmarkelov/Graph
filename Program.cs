using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            var v0 = new Vertex(0);
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);
            var v8 = new Vertex(8);

            graph.AddVertex(v0);
            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);
            graph.AddVertex(v8);


            graph.AddEdge(v0, v1);
            graph.AddEdge(v1, v0);

            graph.AddEdge(v0, v2);
            graph.AddEdge(v2, v0);

            graph.AddEdge(v1, v4);
            graph.AddEdge(v4, v1);

            graph.AddEdge(v1, v5);
            graph.AddEdge(v5, v1);

            graph.AddEdge(v5, v2);
            graph.AddEdge(v2, v5);

            graph.AddEdge(v2, v6);
            graph.AddEdge(v6, v2);

            graph.AddEdge(v6, v7);
            graph.AddEdge(v7, v6);

            graph.AddEdge(v7, v5);
            graph.AddEdge(v5, v7);

            graph.AddEdge(v5, v8);
            graph.AddEdge(v8, v5);

            graph.AddEdge(v8, v3);
            graph.AddEdge(v3, v8);

            graph.AddEdge(v3, v4);
            graph.AddEdge(v4, v3);

            var matrix = graph.GetMatrix();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write(" " + matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
