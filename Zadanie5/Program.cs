using System;

namespace RównanieKwadratowe
{
    public class RownanieKwadratowe
    {
        public static (double x1, double x2) ObliczPierwiastki(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                // Brak pierwiastków rzeczywistych
                return (double.NaN, double.NaN);
            }
            else if (delta == 0)
            {
                // Jeden pierwiastek rzeczywisty
                double x = -b / (2 * a);
                Console.WriteLine("Jeden pierwiastek rzeczywisty");
                return (x, double.NaN);
            }
            else
            {
                // Dwa pierwiastki rzeczywiste
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return (x1, x2);
            }
        }
    }

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

            var (x1, x2) = RownanieKwadratowe.ObliczPierwiastki(a, b, c);

            Console.WriteLine("Pierwiastki równania kwadratowego:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");

            Console.ReadKey();
        }
    }
}
