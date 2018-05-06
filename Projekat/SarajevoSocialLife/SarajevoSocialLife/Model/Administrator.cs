using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoSocialLife.Model
{
    class Administrator : Osoba
    {
        List<Korisnik> korisnici;
        public Administrator(string ime, string prezime, string spol, string username, string password, DateTime rodjenje, List<Korisnik> korisnici) : base(ime, prezime, spol, username, password, rodjenje)
        {
            this.Korisnici = korisnici;
        }

        internal List<Korisnik> Korisnici { get => korisnici; set => korisnici = value; }
    }
}
