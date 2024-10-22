
using Lab01;

public class Program
{
    public static void Main(string[] args)
    {
        // Zad 01
        //Zad01();

        // Zad 02
        Calculator calculator = new Calculator();
        calculator.StartCalculator();
    }

    public static void Zad01()
    {
        double a = DoubleInput();
        double b = DoubleInput();
        double c = DoubleInput();
        double x1, x2, delta;

        if (a == 0) Console.WriteLine("To nie jest rownanie kwadratowe!");
        else
        {
            delta = (Math.Pow(b, 2) - (4 * a * c));
            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Dwa rozwiązania, x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Jedno rozwiązanie, x1 = {x1}");
            }
            else Console.WriteLine("Brak rozwiązania w zbiorze liczb rzecziwistych!");
        }
    }

    public static double DoubleInput()
    {
        return double.Parse(Console.ReadLine());
    }
}