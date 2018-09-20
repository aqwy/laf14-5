using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf14_5
{
    class Vertex
    {
        public char label;        // label (e.g. 'A')
        public bool isInTree;
        public Vertex(char lab)   // constructor
        {
            label = lab;
            isInTree = false;
        }
    }
}
