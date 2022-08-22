using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class Egitim
    {
        [Key]
        [Column("EgitimID")]
        public int EgitimId { get; set; }
        [Required]
        [StringLength(500)]
        public string KurumAd { get; set; }
        [Required]
        [StringLength(550)]
        public string EgitimBaslik { get; set; }
        [Required]
        [StringLength(350)]
        public string Derece { get; set; }
        [Column(TypeName = "date")]
        public DateTime YilindanItibaren { get; set; }
        [Column(TypeName = "date")]
        public DateTime YilinaKadar { get; set; }
        [Required]
        [StringLength(150)]
        public string Sehir { get; set; }
        [Column("UlkeID")]
        public int UlkeId { get; set; }
        [Column("PersonelID")]
        public int PersonelId { get; set; }

        [ForeignKey(nameof(PersonelId))]
        [InverseProperty("Egitim")]
        public virtual Personel Personel { get; set; }
        [ForeignKey(nameof(UlkeId))]
        [InverseProperty("Egitim")]
        public virtual Ulke Ulke { get; set; }
    }
}
