using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Models
{
    [Table("memoires")]
    public class Memoire
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        [DisplayName("Sujet du memoire")]
        public string Sujet { get; set; }

        [DisplayName("Description du sujet")]
        [Required, MaxLength(1000)]
        public string Description { get; set; }

        [Required, MaxLength(50)]
        [DisplayName("Nom du document")]
        public string Filename { get; set; }

        [DisplayName("Annee de soutenance")]
        [Required]
        public DateTime CreatedDate { get; set;}

        [Required]
        public DateTime UpdatedDate { get; set;} = DateTime.Now;

        [DisplayName("Id Encadreur")]

        /// cle etrangere referencant l'encadreur du memoire
        public int? idEncadreur { get; set;}
        [ForeignKey("idEncadreur")]
        public Encadreur encadreur { get; set; }
    }
}