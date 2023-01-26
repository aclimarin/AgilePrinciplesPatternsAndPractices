// See https://aka.ms/new-console-template for more information

using Shape;
using System.Collections;

ArrayList shapes = new ArrayList();

IShape circle1 = new Circle();
IShape square1 = new Square();
IShape circle2 = new Circle();
IShape square2 = new Square();
IShape circle3 = new Circle();
IShape square3 = new Square();
IShape circle4 = new Circle();

IShape rectangle1 = new Rectangle();
IShape rectangle2 = new Rectangle();
IShape rectangle3 = new Rectangle();

shapes.Add(circle1);
shapes.Add(square1);
shapes.Add(circle2);
shapes.Add(square2);
shapes.Add(circle3);
shapes.Add(square3);
shapes.Add(circle4);
shapes.Add(rectangle1);
shapes.Add(rectangle2);
shapes.Add(rectangle3);

DrawAllShapes.Draw(shapes);