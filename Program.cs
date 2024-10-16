namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            double areaCircle1 = circle1.GetArea(circle1.Radie);
            double areaCircle2 = circle2.GetArea(circle2.Radie);

            Console.WriteLine($"Area of circle 1: {areaCircle1}\nArea of circle 2: {areaCircle2}");
        }
    }
}
