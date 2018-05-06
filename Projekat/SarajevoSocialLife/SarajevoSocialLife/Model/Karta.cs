using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoSocialLife.Model
{
    class Karta
    {
        int id;
        Event dogadjaj;

        public Karta(int id, Event dogadjaj)
        {
            this.Id = id;
            this.Dogadjaj = dogadjaj;
        }

        public int Id { get => id; set => id = value; }
        internal Event Dogadjaj { get => dogadjaj; set => dogadjaj = value; }
    }
}
