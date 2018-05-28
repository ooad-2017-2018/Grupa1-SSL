using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarajevoSocialLife.Model
{
    class SSL
    {
        List<Korisnik> korisnici;
        List<Karta> karte;
        List<Event> eventi;
        Organizator org;
        Administrator admin;

        public SSL()
        {
            this.Korisnici = new List<Korisnik>();
            this.Karte = new List<Karta>();
            this.Eventi = new List<Event>();
            this.Org = org;
            this.Admin = admin;
        }

        public SSL(List<Korisnik> korisnici, List<Karta> karte, List<Event> eventi, Organizator org, Administrator admin)
        {
            this.Korisnici = new List<Korisnik>();
            this.Karte = new List<Karta>();
            this.Eventi = new List<Event>();
            this.Org = org;
            this.Admin = admin;
        }
        public Organizator Org
        {
            get
            {
                return org;
            }

            set
            {
                org = value;
            }
        }

        internal Administrator Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }

        internal List<Korisnik> Korisnici { get => korisnici; set => korisnici = value; }
        internal List<Karta> Karte { get => karte; set => karte = value; }
        internal List<Event> Eventi { get => eventi; set => eventi = value; }

        public void UpisiAdministratora(Administrator a)
        {
            admin = a;
        }

    }
}
