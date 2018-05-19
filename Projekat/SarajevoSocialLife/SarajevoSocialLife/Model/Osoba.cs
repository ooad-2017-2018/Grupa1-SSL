using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoSocialLife.Model
{
    abstract class Osoba
    {
        string ime, prezime, spol, username, password;
        DateTime rodjenje;

        public Osoba(string ime, string prezime, string spol, string username, string password, DateTime rodjenje)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.spol = spol;
            this.username = username;
            this.password = password;
            this.rodjenje = rodjenje;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Spol { get => spol; set => spol = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Rodjenje { get => rodjenje; set => rodjenje = value; }
    }
}
