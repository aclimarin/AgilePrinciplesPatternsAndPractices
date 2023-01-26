using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple.List10_3
{
    public class Square : Rectangle
    {
        public override double Width
        {
            set
            {
                base.width = value;
                base.height = value;
            }
        }

        public override double Height
        {
            set
            {
                base.width = value;
                base.height = value;
            }
        }
    }
}
