using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class Beceri
    {
        [Key]
        [Column("BeceriID")]
        public int BeceriId { get; set; }
        [Required]
        [StringLength(1000)]
        public string BeceriAd { get; set; }
        [Column("PersonelID")]
        public int PersonelId { get; set; }

        [ForeignKey(nameof(PersonelId))]
        [InverseProperty("Beceri")]
        public virtual Personel Personel { get; set; }
    }
}
