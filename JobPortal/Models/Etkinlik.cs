using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class Etkinlik
    {
        [Key]
        [Column("EtkinlikID")]
        public int EtkinlikId { get; set; }
        [Column("KullaniciID")]
        public int KullaniciId { get; set; }
        [Column("SirketID")]
        public int SirketId { get; set; }
        [Required]
        [StringLength(250)]
        public string EtkinlikBaslik { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EtkinlikTarih { get; set; }
        [Required]
        [StringLength(500)]
        public string Konum { get; set; }
        [Column(TypeName = "date")]
        public DateTime BaslangicTarihi { get; set; }
        [Column(TypeName = "date")]
        public DateTime BitisTarihi { get; set; }
        [Required]
        [StringLength(500)]
        public string EtkinlikIletisim { get; set; }
        [Required]
        [StringLength(2000)]
        public string Aciklama { get; set; }
        [Required]
        public string EtkinlikAfis { get; set; }

        [ForeignKey(nameof(SirketId))]
        [InverseProperty(nameof(Kullanici.Etkinlik))]
        public virtual Kullanici Sirket { get; set; }
        [ForeignKey(nameof(SirketId))]
        [InverseProperty("Etkinlik")]
        public virtual Sirket SirketNavigation { get; set; }
    }
}
