using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PraktyczneKursy.Models
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }

        [Required(ErrorMessage = "Wprowadź Imię")]
        [StringLength(50)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowadź Nazwisko")]
        [StringLength(50)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowadź Ulicę")]
        [StringLength(100)]
        public string Ulica { get; set; }
        [Required(ErrorMessage = "Wprowadź Miasto")]
        [StringLength(100)]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Wprowadź Kod Pocztowy")]
        [StringLength(6)]
        public string KodPocztowy { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Komentarz { get; set; }
        public DateTime DataDodania { get; set; }
        public StanZamowienia StanZamowienia { get; set; }
        public decimal WartoscZamowienia { get; set; }

       List<PozycjeZamowienia> PozycjeZamowienia { get; set; }

    }
    public enum StanZamowienia {
        Nowe,
        Zrealizowae
    }
}
