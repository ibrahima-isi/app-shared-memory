using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Models
{
    //[Table("encadreurs")]
    public class Encadreur: Personne
    {
        [DisplayName("Specialité")]
        [Required, MaxLength(20)]
        public string specialite { get; set; }
    }
}