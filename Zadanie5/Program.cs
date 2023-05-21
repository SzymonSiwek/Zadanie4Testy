using System;

namespace RównanieKwadratowe
{   
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj współczynniki równania kwadratowego ax^2 + bx + c = 0");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pierwiastki równania kwadratowego:");

            Console.ReadKey();
        }
    }
}
