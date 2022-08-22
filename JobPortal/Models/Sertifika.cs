using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
