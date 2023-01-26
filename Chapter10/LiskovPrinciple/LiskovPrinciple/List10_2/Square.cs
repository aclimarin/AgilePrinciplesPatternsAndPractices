using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List10_2
{
    public class Square : Rectangle
    {
        public new double Width
        {
            set
            {
                base.width = value;
                base.height = value;
            }
        }

        public new double Height
        {
            set
            {
                base.width = value;
                base.height = value;
            }
        }
    }
}
