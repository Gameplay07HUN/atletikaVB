using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atletikaVB
{
    internal class Versenyekszamok
    {
        readonly string versenyszam;
        readonly string nem;
        readonly int nemzetKod;
        readonly string versenyzoNev;
        readonly double eredmeny;
        readonly string csucs;
        readonly int helyezes;

        public string Versenyszam => versenyszam;
        public string Nem => nem;
        public int NemzetKod => nemzetKod;
        public string Csucs => csucs;
        public int Helyezes => helyezes;
        public double Eredmeny => eredmeny;
        public string VersenyzoNev => versenyzoNev;

        public Versenyekszamok(string versenyszam, string nem, int nemzetKod, string versenyzoNev, double eredmeny, string csucs, int helyezes)
        {
            this.versenyszam = versenyszam;
            this.nem = nem;
            this.nemzetKod = nemzetKod;
            this.versenyzoNev = versenyzoNev;
            this.eredmeny = eredmeny;
            this.csucs = csucs;
            this.helyezes = helyezes;
        }
    }

}
