using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List10_2
{
    public class Rectangle
    {
        private Point topLeft;
        protected double width;
        protected double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// viola LSP
        /// </summary>
        public void f(Rectangle r)
        {
            r.Width = 23;
        }
    }
}
