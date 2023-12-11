namespace Solution
{
    public class AreaCalculator
    {
        public string Area(List<IShape> shapes)
        {
            string area = string.Empty;

            foreach (var shape in shapes)
            {
                area += shape.Area();
                area += Environment.NewLine;
            }

            return area;
        }
    }
}
