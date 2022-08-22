using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class IsDeneyim
    {
        [Key]
        [Column("IsDeneyimID")]
        public int IsDeneyimId { get; set; }
        [Column("PersonelID")]
        public int PersonelId { get; set; }
        [Required]
        [StringLength(550)]
        public string Sirket { get; set; }
        [Required]
        [StringLength(500)]
        public string Baslik { get; set; }
        [Column("UlkeID")]
        public int UlkeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime YilindanItibaren { get; set; }
        [Column(TypeName = "date")]
        public DateTime YilinaKadar { get; set; }
        [Required]
        [StringLength(2000)]
        public string Aciklama { get; set; }

        [ForeignKey(nameof(PersonelId))]
        [InverseProperty("IsDeneyim")]
        public virtual Personel Personel { get; set; }
        [ForeignKey(nameof(UlkeId))]
        [InverseProperty("IsDeneyim")]
        public virtual Ulke Ulke { get; set; }
    }
}
