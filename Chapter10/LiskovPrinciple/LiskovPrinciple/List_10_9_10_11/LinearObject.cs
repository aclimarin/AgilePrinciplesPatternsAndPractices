using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List_10_9_10_11
{
    public abstract class LinearObject
    {
        private Point p1;
        private Point p2;

        public LinearObject(Point p1, Point p2)
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
