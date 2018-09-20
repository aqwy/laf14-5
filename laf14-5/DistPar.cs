using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laf14_5
{
    class DistPar
    {
        public int distance;   // distance from start to this vertex
        public int parentVert; // current parent of this vertex
        public DistPar(int pv, int d)  // constructor
        {
            distance = d;
            parentVert = pv;
        }
    }
}
