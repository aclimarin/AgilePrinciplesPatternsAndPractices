using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List10_3
{
    public class Rectangle
    {
        private Point topLeft;
        protected double width;
        protected double height;

        public virtual double Width
        {
            get { return width; }
            set { width = value; }
        }

        public virtual double Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// viola LSP
        /// </summary>
        public void g(Rectangle r)
        {
            r.Width = 5;
            r.height = 4;

            if (r.Area() != 20)
                throw new Exception("Áera incorreta!");
        }

        private double Area()
        {
            return width * height;
        }
    }
}
