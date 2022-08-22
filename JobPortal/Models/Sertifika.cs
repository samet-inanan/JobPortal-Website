using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class Sertifika
    {
        [Key]
        [Column("SertifikaID")]
        public int SertifikaId { get; set; }
        [Column("PersonelID")]
        public int PersonelId { get; set; }
        [Required]
        [StringLength(500)]
        public string SertifikaAd { get; set; }
        [Required]
        [StringLength(1000)]
        public string SertifikaYetkili { get; set; }
        [Required]
        [StringLength(150)]
        public string SertifikaLevel { get; set; }
        [Column(TypeName = "date")]
        public DateTime YilindanItibaren { get; set; }

        [ForeignKey(nameof(PersonelId))]
        [InverseProperty("Sertifika")]
        public virtual Personel Personel { get; set; }
    }
}
