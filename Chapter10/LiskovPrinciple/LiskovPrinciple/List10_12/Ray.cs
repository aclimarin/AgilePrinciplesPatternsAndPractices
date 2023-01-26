using LiskovPrinciple.List_10_9_10_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List10_12
{
    public class Ray : LinearObject
    {
        public Ray(Point p1, Point p2) : base(p1, p2)
        {
        }

        public override bool IsOn()
        {
            return base.IsOn();//code

        }
    }
}
