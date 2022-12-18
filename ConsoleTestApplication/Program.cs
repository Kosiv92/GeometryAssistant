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
               $"Triangle1 is right:{triangle1.IsRight}\n" + $"Triangle1 area: {triangle1.GetAreaValue()}\nTriangle1 perimeter: {triangle1.GetPerimetrValue()}");

            Console.WriteLine($"Triangle2 sides: {triangle2.FirstSideLength}, {triangle2.SecondSideLength}, {triangle2.ThirdSideLength}\n" +
                $"Triangle2 is right:{triangle2.IsRight}\n" + $"Triangle2 area: {triangle2.GetAreaValue()}\nTriangle2 perimeter: {triangle2.GetPerimetrValue()}");

            Console.WriteLine($"Triangle3 sides: {triangle3.FirstSideLength}, {triangle3.SecondSideLength}, {triangle3.ThirdSideLength}\n" +
                $"Triangle3 is right:{triangle3.IsRight}\n" + $"Triangle3 area: {triangle3.GetAreaValue()}\nTriangle3 perimeter: {triangle3.GetPerimetrValue()}");

            Console.ReadKey();




        }
    }
}