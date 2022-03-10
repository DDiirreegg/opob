using System;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ułamek ułamek = new Ułamek();
            Ułamek ułamek1 = new Ułamek();
        }
    }
    class Ułamek
    {
        private int licznik;
        private int mianownik;

        public Ułamek()
        {
            this.licznik = 0;
            this.mianownik = 1;
        }
        public Ułamek(Ułamek A_U)
        {
            this.licznik = A_U.licznik;
            this.mianownik = A_U.mianownik;
        }
        public override string ToString()
        {
            return "licznik=" + this.licznik + " mianowk=" + this.mianownik;
        }
    }


}
