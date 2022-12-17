using GeometryAssistant;
using GeometryAssistant.Figures;

namespace ConsoleTestApplication


{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(3, 4, 5);

            Triangle triangle2 = new Triangle(2, 4);

            Triangle triangle3 = new Triangle(2);

            Console.WriteLine($"Triangle1 sides: {triangle1.FirstSideLength}, {triangle1.SecondSideLength}, {triangle1.ThirdSideLength}\n" +
                $"Triangle1 is isosceles: {triangle1.IsIsosceles}\nTriangle1 is equilateral:{triangle1.IsEquilateral}\nTriangle1 is right:{triangle1.IsRight}");

            Console.WriteLine($"Triangle2 sides: {triangle2.FirstSideLength}, {triangle2.SecondSideLength}, {triangle2.ThirdSideLength}\n" +
                $"Triangle2 is isosceles: {triangle2.IsIsosceles}\nTriangle2 is equilateral:{triangle2.IsEquilateral}\nTriangle2 is right:{triangle2.IsRight}");

            Console.WriteLine($"Triangle3 sides: {triangle3.FirstSideLength}, {triangle3.SecondSideLength}, {triangle3.ThirdSideLength}\n" +
                $"Triangle3 is isosceles: {triangle3.IsIsosceles}\nTriangle3 is equilateral:{triangle3.IsEquilateral}\nTriangle3 is right:{triangle3.IsRight}");

            Console.ReadKey();




        }
    }
}