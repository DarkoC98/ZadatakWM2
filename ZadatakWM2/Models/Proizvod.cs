using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZadatakWM2.Models
{
    public class Proizvod
    {
        public int id;
        public string naziv;
        public string opis;
        public string kategorija;
        public string proizvodjac;
        public string dobavljac;
        public float cena;

    }
    public class Proizvodi
    {
        public IList<Proizvod> proizvods;
    }
}