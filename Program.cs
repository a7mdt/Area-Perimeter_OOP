namespace shapesOPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Square(3)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name}");
                Console.WriteLine($"Area: {shape.calcArea()}");
                Console.WriteLine($"Perimeter: {shape.calcPerimeter()}");
                Console.WriteLine();
            }
        }
    }
}
