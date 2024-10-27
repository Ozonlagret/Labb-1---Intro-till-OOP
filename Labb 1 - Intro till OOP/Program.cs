namespace Labb_1___Intro_till_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();

            circle1.Radius = 5;

            float area = circle1.GetArea(circle1.Radius, circle1._pi);

            Console.WriteLine(area);
        }
    }
}
