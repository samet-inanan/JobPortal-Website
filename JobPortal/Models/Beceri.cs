using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
