using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoSocialLife.Model
{
    class Korisnik:Osoba
    {
        bool aktivan;

        public Korisnik(string ime, string prezime, string spol, string username, string password, DateTime rodjenje, bool akt) : base(ime, prezime, spol, username, password, rodjenje)
        {
            Aktivan = akt;
        }

        public bool Aktivan { get => aktivan; set => aktivan = value; }
    }
}
