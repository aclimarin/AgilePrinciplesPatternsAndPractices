using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List10_7
{
    public class Line
    {
        private Point p1;
        private Point p2;

        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public Point P1
        {
            get { return p1; }
        }

        public Point Point2
        {
            get { return p2; }
        }

        public double Slop
        {
            get
            {
                return 0;//code
            }
        }

        public double YIntercept
        {
            get
            {
                return 0;//code
            }
        }

        public virtual bool IsOn()
        {
            return true;//code
        }
    }
}
