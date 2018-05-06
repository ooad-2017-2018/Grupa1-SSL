using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoSocialLife.Model
{
    class Mjesto
    {
        int id;
        string ulica;
        int broj;

        public Mjesto(int id, string ulica, int broj)
        {
            this.Id = id;
            this.Ulica = ulica;
            this.Broj = broj;
        }

        public int Broj { get => broj; set => broj = value; }
        public int Id { get => id; set => id = value; }
        public string Ulica { get => ulica; set => ulica = value; }
    }
}
