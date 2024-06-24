using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
     class Point
    {
        public int x; //4 bytes
        public int y; //4 bytes

        public override string ToString()
        {
            return $"{x},{y}";
        }
    }
}
