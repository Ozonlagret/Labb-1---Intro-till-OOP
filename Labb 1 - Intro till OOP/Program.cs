namespace Labb_1___Intro_till_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            circle1.radius = 5;

            Console.WriteLine(circle1.GetArea(circle1.radius, circle1._pi));
            Console.WriteLine(circle2.GetArea(circle2.radius, circle1._pi));            
        }
    }
}
