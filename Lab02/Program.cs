using Lab02;

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.Marka = "Toyota";
        car.Model = "Camry 3.5";
        car.View();

        try
        {
            // Zadanie 01
            Osoba osoba01 = new Osoba("Jan", "Bolowski", -27);
            osoba01.WyswietlInformacje();

            // Zadanie 02
            BankAccount konto = new BankAccount(osoba01, 1000);
            konto.Wplata(500);
            konto.Wyplata(200);
            Console.WriteLine($"Saldo: {konto.Saldo}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        // Zadanie 03
        Student student01 = new Student("Jakusz", "Hokarz");
        student01.DodajOcene(3);
        Console.WriteLine($"Srednia ocena studenta {student01.ToString()} ruwna się {student01.SredniaOcen}");
        student01.DodajOcene(4.5f);
        Console.WriteLine($"Srednia ocena studenta {student01.ToString()} ruwna się {student01.SredniaOcen}");
    }
}