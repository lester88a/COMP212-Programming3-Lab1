using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP212__F15_Lab1_Li
{
    class ThresholdReachedEventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
        //there is a default constructor if you don't difinde any constructor
        public string Nihao = "ni hao";
    }
}
