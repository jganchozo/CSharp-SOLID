namespace Solution
{
    public class Circle: IShape
    {
        public double Radius { get; set; }

        public string Area()
        {
            return $"Circulo: {Radius * Radius * Math.PI}";
        }
    }
}
