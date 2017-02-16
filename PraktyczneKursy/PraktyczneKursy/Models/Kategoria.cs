using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PraktyczneKursy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę kategorii")]
        [StringLength(100)]
        public string NazwaKategori { get; set; }
        [Required(ErrorMessage = "Wprowadź opis kategorii")]
        public string OpisKategori { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Kurs> Kursy { get; set; }
    }
}