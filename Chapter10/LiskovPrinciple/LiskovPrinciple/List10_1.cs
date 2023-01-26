using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//LSP Violation
namespace LiskovPrinciple
{
    public struct Point { double x, y; }
    public enum ShapeType { square, circle }
    
    public class Shape
    {
        private ShapeType type;
        public Shape(ShapeType type)
        {
            this.type = type;
        }

        public static void DrawShape(Shape s)
        {
            if (s.type == ShapeType.square)
                (s as Square).Draw();
            else if (s.type == ShapeType.circle)
                (s as Circle).Draw();
        }
    }

    public class Circle: Shape
    {
        private Point center;
        private double radius;

        public Circle(): base(ShapeType.circle)
        {

        }

        public void Draw()
        {
            //draw circle
        }
    }

    public class Square: Shape
    {
        private Point topLeft;
        private double side;

        public Square(): base(ShapeType.square)
        {

        }

        public void Draw()
        {
            //draw square
        }
    }
}
