using System.Collections;

namespace Shape
{
    public static class DrawAllShapes
    {
        public static void Draw(ArrayList shapes)
        {
            shapes.Sort(new ShapeComparer());
            foreach (IShape shape in shapes)
                shape.Draw();
        }
    }
}
