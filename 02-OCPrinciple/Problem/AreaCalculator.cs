namespace Problem
{
    public class AreaCalculator
    {
        public string Area(List<object> shapes)
        {
            string area = string.Empty;

            foreach (var shape in shapes)
            {
                if (shape is Rectangle rectangle)
                {
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
