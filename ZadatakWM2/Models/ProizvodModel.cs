using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZadatakWM2.Models
{
    public class ProizvodModel
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string kategorija { get; set; }
        public string proizvodjac { get; set; }
        public string dobavljac { get; set; }
        public float cena { get; set; }

    }
}