using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoSocialLife.Model
{
    class Event
    {
        string naziv, opis, lokacija;
        int id;
        Mjesto mjesto;
        DateTime datum;

        public Event(string naziv, string opis, string lokacija, int id, Mjesto mjesto, DateTime datum)
        {
            this.Naziv = naziv;
            this.Opis = opis;
            this.Lokacija = lokacija;
            this.Id = id;
            this.Mjesto = mjesto;
            this.Datum = datum;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }
        public int Id { get => id; set => id = value; }
        public Mjesto Mjesto { get => mjesto; set => mjesto = value; }
        public DateTime Datum { get => datum; set => datum = value; }
    }
}
