using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    internal class AreaCalculator
    {
        public string Area(List<object> shapes)
        {
            string area = string.Empty;

            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    area += "Rectangulo: " + rectangle.With * rectangle.Height;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    area += "Circulo: " + circle.Radius * circle.Radius * Math.PI;
                }

                area += Environment.NewLine;
            }

            return area;
        }
    }
}
