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
        public DateOnly DatumNarozeni { get; private set; }
        public string Telefon { get; private set; }

        public Pojistenci(string jmeno, string prijmeni, DateOnly datumNarozeni, string telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            Telefon = telefon;
        }

        public int Vek()
        {
            DateTime dnes = DateTime.Today;
            if (!(dnes.Month > DatumNarozeni.Month))
            {
                if (dnes.Month == DatumNarozeni.Month)
                {
                    if (!(dnes.Day < DatumNarozeni.Day))
                        return dnes.Year - DatumNarozeni.Year;
                    else return (dnes.Year - DatumNarozeni.Year) - 1;
                }
                else return (dnes.Year - DatumNarozeni.Year) - 1;
            }                
            else return dnes.Year - DatumNarozeni.Year;
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + ", " + Vek() + " let, tel.: " + Telefon;
        }
    }
}