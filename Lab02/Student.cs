namespace Lab02
{
    public class Student
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public List<float> TablicaOcen = new List<float>();
        public float SredniaOcen
        {
            get
            {
                if (TablicaOcen.Count <= 0)
                    return 0;

                float sredOcen = 0;
                foreach (var ocen in TablicaOcen)
                {
                    sredOcen += ocen;
                }
                return sredOcen / TablicaOcen.Count;
            }
        }

        public Student(string imie, string nazwisko)
        { 
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public void DodajOcene(float ocena) => TablicaOcen.Add(ocena);

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
