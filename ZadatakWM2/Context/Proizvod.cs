//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZadatakWM2.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Proizvod
    {
        public int id { get; set; }
        [Required(ErrorMessage ="Required")]
        public string naziv { get; set; }
        [Required(ErrorMessage = "Required")]
        public string opis { get; set; }
        [Required(ErrorMessage = "Required")]
        public string kategorija { get; set; }
        [Required(ErrorMessage = "Required")]
        public string proizvodjac { get; set; }
        [Required(ErrorMessage = "Required")]
        public string dobavljac { get; set; }
        [Required(ErrorMessage = "Required")]
        public double cena { get; set; }
    }
}
