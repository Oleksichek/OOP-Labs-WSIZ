namespace Lab02
{
    public class Osoba
    {
        private string _imie;
        private string _nazwisko;
        private int _wiek;

        public string Imie
        {
            get { return _imie; }
            set {
                if (value.Length < 2)
                {
                    throw new ArgumentException($"Imię musi mieć co najmniej 2 znaki");
                }
                _imie = value;
            }
        }
        public string Nazwisko
        {
            get { return _nazwisko; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException($"Nazwisko musi mieć co najmniej 2 znaki");
                }
                _nazwisko = value;
            }
        }
        public int Wiek 
        {
            get { return _wiek; }
            set
            {
                if (value < 0)
                    return;
                _wiek = value;
            }
        }

        public Osoba(string imie, string nazwisko, int wiek)
        { 
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyswietlInformacje() => Console.WriteLine($"Osoba nazywa się {Imie} {Nazwisko} i ma {Wiek} lat");
    }
}
