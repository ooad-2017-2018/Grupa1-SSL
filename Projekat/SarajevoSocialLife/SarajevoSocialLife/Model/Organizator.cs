using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoSocialLife.Model
{
    class Organizator:Osoba
    {
        string organizacija;
        List<Event> eventi;

        public Organizator(string ime, string prezime, string spol, string username, string password, DateTime rodjenje, string organizacija, List<Event> eventi) : base(ime, prezime, spol, username, password, rodjenje)
        {
            this.Organizacija = organizacija;
            this.Eventi = new List<Event>();
        }

        public string Organizacija { get => organizacija; set => organizacija = value; }
        public List<Event> Eventi { get => eventi; set => eventi = value; }
    }
}
