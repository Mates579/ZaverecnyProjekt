using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    internal class Pojistenci
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public string Telefon { get; private set; }

        public Pojistenci(string jmeno, string prijmeni, int vek, string telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + ", " + Vek + " let, tel.: " + Telefon;
        }
    }
}