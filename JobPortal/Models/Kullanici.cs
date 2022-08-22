using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            Etkinlik = new HashSet<Etkinlik>();
            IsIlani = new HashSet<IsIlani>();
            Personel = new HashSet<Personel>();
            Sirket = new HashSet<Sirket>();
        }

        [Key]
        [Column("KullaniciID")]
        public int KullaniciId { get; set; }
        [Column("KullaniciTipID")]
        public int KullaniciTipId { get; set; }
        [Required]
        [StringLength(150)]
        public string KullaniciAd { get; set; }
        [Required]
        [StringLength(150)]
        public string Parola { get; set; }
        [Required]
        [StringLength(150)]
        public string EmailAdres { get; set; }
        [Required]
        [StringLength(20)]
        public string İletisimNo { get; set; }
        [Column("HesapDurumuID")]
        public int HesapDurumuId { get; set; }

        [ForeignKey(nameof(HesapDurumuId))]
        [InverseProperty("Kullanici")]
        public virtual HesapDurumu HesapDurumu { get; set; }
        [ForeignKey(nameof(KullaniciTipId))]
        [InverseProperty(nameof(KullaniciTipi.Kullanici))]
        public virtual KullaniciTipi KullaniciTip { get; set; }
        [InverseProperty("Sirket")]
        public virtual ICollection<Etkinlik> Etkinlik { get; set; }
        [InverseProperty("Kullanici")]
        public virtual ICollection<IsIlani> IsIlani { get; set; }
        [InverseProperty("Kullanici")]
        public virtual ICollection<Personel> Personel { get; set; }
        [InverseProperty("Kullanici")]
        public virtual ICollection<Sirket> Sirket { get; set; }
    }
}
