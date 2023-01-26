using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List10_7
{
    public class LineSegment : Line
    {
        public LineSegment(Point p1, Point p2) : base(p1, p2)
        {
        }

        public double Length()
        {
            return 0; //code
        }

        public override bool IsOn()
        {
            return true; //code
        }

    }
}
