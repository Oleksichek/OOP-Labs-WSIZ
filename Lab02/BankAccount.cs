namespace Lab02
{
    public class BankAccount
    {
        public Osoba Osoba { get; private set; }
        public float Saldo { get; private set; }

        public BankAccount(Osoba osoba, float saldo)
        {
            Osoba = osoba;
            Saldo = saldo;
        }

        public void Wplata(float kwota) => Saldo += kwota;

        public bool Wyplata(float kwota)
        {
            if (Saldo < kwota)
                return false;

            Saldo -= kwota;
            return true;
        }
    }
}
