using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.Polymorphism
{
    internal class Class1
    {
        static void Main1(string[] args)
        {
            //var shapes = new List<Shape>();
            //shapes.Add(new Circle());
            //shapes.Add(new Rectangle());

            //var canvas = new Canvas();
            //canvas.DrawShapes(shapes);
            //var shape = new Shape();



            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

        }
    }
}
