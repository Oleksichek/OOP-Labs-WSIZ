namespace Lab01
{
    public class Calculator
    {
        private bool _isClosed = false;

        public void StartCalculator()
        {
            while (!_isClosed)
            {
                Console.Clear();
                Console.WriteLine("$$Calculator$$\nWybierz opcje:\n1.+\n2.-\n3.*\n4./\n5.x2\n6.Pierw\n7.Tryg\n8.Koniec\n");

                float tempX;

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        ToBasicCalculate(1);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        ToBasicCalculate(2);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        ToBasicCalculate(3);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        ToBasicCalculate(4);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine("Proszę podać wartość x2:\n");
                        if (!float.TryParse(Console.ReadLine(), out tempX))
                        {
                            Console.WriteLine("Podana wartość nie jest liczbą!");
                            Console.ReadKey();
                        }
                        Console.WriteLine("Odpowiedż: " + tempX * tempX);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Console.WriteLine("Proszę podać wartość A:\n");
                        if (!float.TryParse(Console.ReadLine(), out tempX))
                        {
                            Console.WriteLine("Podana wartość nie jest liczbą!");
                            Console.ReadKey();
                        }
                        Console.WriteLine("Odpowiedż: " + Math.Sqrt(tempX));
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D7:
                        ToTriginometryCalculate();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D8:
                        _isClosed = true;
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }

        public void ToBasicCalculate(int calculateType)
        {
            Console.Clear();
            Console.WriteLine("Proszę podać wartość A:\n");
            if (!float.TryParse(Console.ReadLine(), out float a))
            {
                Console.WriteLine("Podana wartość nie jest liczbą!\n");
                Console.ReadKey();
                ToBasicCalculate(calculateType);
                return;
            }

            Console.WriteLine("Proszę podać wartość B:\n");
            if (!float.TryParse(Console.ReadLine(), out float b))
            {
                Console.WriteLine("Podana wartość nie jest liczbą!\n");
                Console.ReadKey();
                ToBasicCalculate(calculateType);
                return;
            }

            float result;

            switch (calculateType)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                case 4:
                    result = a / b;
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine("\nOdpowiedż: " + result);
        }

        public void ToTriginometryCalculate()
        {
            Console.Clear();
            Console.WriteLine("Proszę podać typ trygionometrii:\n1.Sin\n2.Cos\n3.Tang\n4.Kotang\n");
            if (!int.TryParse(Console.ReadLine(), out int trigTyp))
            {
                Console.WriteLine("Podana wartość nie jest liczbą!\n");
                Console.ReadKey();
                ToTriginometryCalculate();
                return;
            }

            Console.WriteLine("Proszę podać wartość A:\n");
            if (!float.TryParse(Console.ReadLine(), out float a))
            {
                Console.WriteLine("Podana wartość nie jest liczbą!\n");
                Console.ReadKey();
                ToTriginometryCalculate();
                return;
            }

            double result;

            switch (trigTyp)
            {
                case 1:
                    result = Math.Sin(a);
                    break;
                case 2:
                    result = Math.Cos(a);
                    break;
                case 3:
                    result = Math.Tan(a);
                    break;
                case 4:
                    result = (Math.Cos(a) / Math.Sin(a));
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine("\nOdpowiedż: " + result);
        }
    }
}
