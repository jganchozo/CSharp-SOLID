namespace Solution
{
    public class Rectangle: IShape
    {
        public double With { get; set; }
        public double Height { get; set; }

        public string Area()
        {
            return $"Rectangulo: {With * Height}";
        }
    }
}
