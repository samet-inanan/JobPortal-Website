using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class Sirket
    {
        public Sirket()
        {
            Etkinlik = new HashSet<Etkinlik>();
            IsIlani = new HashSet<IsIlani>();
        }

        [Key]
        [Column("SirketID")]
        public int SirketId { get; set; }
        [Column("KullaniciID")]
        public int KullaniciId { get; set; }
        [Required]
        [StringLength(500)]
        public string SirketAd { get; set; }
        [Required]
        [StringLength(20)]
        public string İletisimNo { get; set; }
        [Required]
        [StringLength(500)]
        public string EmailAdres { get; set; }
        [Required]
        public string Logo { get; set; }
        [StringLength(1000)]
        public string Aciklama { get; set; }

        [ForeignKey(nameof(KullaniciId))]
        [InverseProperty("Sirket")]
        public virtual Kullanici Kullanici { get; set; }
        [InverseProperty("SirketNavigation")]
        public virtual ICollection<Etkinlik> Etkinlik { get; set; }
        [InverseProperty("Sirket")]
        public virtual ICollection<IsIlani> IsIlani { get; set; }
    }
}
