using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapisDoPliku3P
{
    public class Uczen
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set;}
        public bool Plec { get; set;}
        public string Klasa { get; set;}

        public Uczen(string imie, string nazwisko, bool plec, string klasa)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
            Klasa = klasa;
        }
    }
}
