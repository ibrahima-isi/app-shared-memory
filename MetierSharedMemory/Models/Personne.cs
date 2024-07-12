using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Models
{
    [Table("personnes")]
    public class Personne
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nom")]
        [Required, MaxLength(30)]
        public string nom { get; set; }

        [DisplayName("Prenom")]
        [Required, MaxLength(50)]
        public string prenom {  get; set; }
    }
}