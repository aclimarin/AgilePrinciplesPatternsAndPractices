using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List_10_9_10_11
{
    public class LineSegment : LinearObject
    {
        public LineSegment(Point p1, Point p2) : base(p1, p2)
        {
        }

        public override bool IsOn()
        {
            return base.IsOn(); //code
        }
    }
}
