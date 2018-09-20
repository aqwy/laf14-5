using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf14_5
{
    class Graph
    {
        private readonly int MAX_VERTS = 20;
        private readonly int INFINITY = 1000000;
        private Vertex[] vertexList; // list of vertices
        private int[,] adjMat;      // adjacency matrix
        private int nVerts;          // current number of vertices
        private int[] vertexs;		// array for index of vertex in vertexList
        public Graph()               // constructor
        {
            vertexList = new Vertex[MAX_VERTS];
            // adjacency matrix
            adjMat = new int[MAX_VERTS, MAX_VERTS];
            nVerts = 0;
            for (int j = 0; j < MAX_VERTS; j++)
                // set adjacency
                for (int k = 0; k < MAX_VERTS; k++)
                    // matrix
                    adjMat[j, k] = INFINITY;     // to infinity
        }  // end constructor
        public void addVertex(char lab)
        {
            vertexList[nVerts++] = new Vertex(lab);
        }
        public void addEdge(int start, int end, int weight)
        {
            adjMat[start, end] = weight;  // (directed)
            adjMat[end, start] = weight;  // (directed)
        }
        public void displayWord()
        {
            for (int j = 0; j < nVerts; j++)
            {
                Console.Write(" " + vertexList[vertexs[j]].label);
            }
            Console.WriteLine(" " + vertexList[vertexs[0]].label);
        }
        public void travelingSalesman()
        {
            vertexs = new int[nVerts];
            for (int i = 0; i < nVerts; i++)
            {
                vertexs[i] = i;
            }
            doAnagram(vertexs.Length);
        }
        public void doAnagram(int newSize)
        {
            if (newSize == 1)
            {                    // if too small,
                for (int i = 0; i < nVerts - 1; i++)
                {
                    if (adjMat[vertexs[i],vertexs[i + 1]] == INFINITY)
                    {
                        return;
                    }
                }
                if (adjMat[vertexs[nVerts - 1],vertexs[0]] != INFINITY)
                {
                    displayWord();
                }
                return;
            }                          // go no further
            for (int j = 0; j < newSize; j++)         // for each position,
            {
                doAnagram(newSize - 1);             // anagram remaining
                rotate(newSize);
            }
        }
        public void rotate(int newSize)
        // rotate left all chars from position to end
        {
            int j;
            int position = nVerts - newSize;
            int temp = vertexs[position];       // save first letter
            for (j = position + 1; j < nVerts; j++)
                // shift others left
                vertexs[j - 1] = vertexs[j];
            vertexs[j - 1] = temp;                 // put first on right
        }
    }
}
