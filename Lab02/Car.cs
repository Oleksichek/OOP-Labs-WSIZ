namespace Lab02
{
    internal class Car
    {
        public string Marka;
        public string Model;

        private int _rokProdukcji = DateTime.UtcNow.Year;

        public void View()
        {
            Console.WriteLine($"Samochód: {Marka} {Model}, Rok: {_rokProdukcji}");
        }
    }
}
