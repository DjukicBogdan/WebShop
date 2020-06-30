using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
   
    public partial class Porucbenica
    {
        public int OsobaId { get; set; }
        public string ImePrezime { get; set; }
        public string Telefon { get; set; }
        public string Ulica { get; set; }
        public string KucniBroj { get; set; }
        [StringLength(50)]
        public string PostanskiBroj { get; set; }
        [StringLength(50)]
        public string Mesto { get; set; }
        [StringLength(50)]
        public string StaPorucujete { get; set; }
        public int? Kolicina { get; set; }
    }
}