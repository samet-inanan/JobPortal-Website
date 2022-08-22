using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class Personel
    {
        public Personel()
        {
            Beceri = new HashSet<Beceri>();
            Diller = new HashSet<Diller>();
            Egitim = new HashSet<Egitim>();
            IsBasvuru = new HashSet<IsBasvuru>();
            IsDeneyim = new HashSet<IsDeneyim>();
            Sertifika = new HashSet<Sertifika>();
        }

        [Key]
        [Column("PersonelID")]
        public int PersonelId { get; set; }
        [Column("KullaniciID")]
        public int KullaniciId { get; set; }
        [Column("IsKategoriID")]
        public int IsKategoriId { get; set; }
        [Required]
        [StringLength(150)]
        public string PersonelAd { get; set; }
        [Column(TypeName = "date")]
        public DateTime DogumTarihi { get; set; }
        [Column("UlkeID")]
        public int UlkeId { get; set; }
        [Required]
        [StringLength(150)]
        public string EmailAdres { get; set; }
        [Required]
        [StringLength(20)]
        public string Cinsiyet { get; set; }
        [Required]
        public string Fotograf { get; set; }
        [Required]
        [StringLength(150)]
        public string Yeterlilik { get; set; }
        [Required]
        [StringLength(500)]
        public string Adres { get; set; }
        [Required]
        [StringLength(250)]
        public string IsReferanslar { get; set; }
        [Required]
        [StringLength(3000)]
        public string Aciklama { get; set; }
        [Column("SimdikiIsDurumuID")]
        public int SimdikiIsDurumuId { get; set; }

        [ForeignKey(nameof(IsKategoriId))]
        [InverseProperty("Personel")]
        public virtual IsKategori IsKategori { get; set; }
        [ForeignKey(nameof(KullaniciId))]
        [InverseProperty("Personel")]
        public virtual Kullanici Kullanici { get; set; }
        [ForeignKey(nameof(KullaniciId))]
        [InverseProperty(nameof(Ulke.Personel))]
        public virtual Ulke KullaniciNavigation { get; set; }
        [ForeignKey(nameof(SimdikiIsDurumuId))]
        [InverseProperty("Personel")]
        public virtual SimdikiIsDurumu SimdikiIsDurumu { get; set; }
        [InverseProperty("Personel")]
        public virtual ICollection<Beceri> Beceri { get; set; }
        [InverseProperty("Personel")]
        public virtual ICollection<Diller> Diller { get; set; }
        [InverseProperty("Personel")]
        public virtual ICollection<Egitim> Egitim { get; set; }
        [InverseProperty("Personel")]
        public virtual ICollection<IsBasvuru> IsBasvuru { get; set; }
        [InverseProperty("Personel")]
        public virtual ICollection<IsDeneyim> IsDeneyim { get; set; }
        [InverseProperty("Personel")]
        public virtual ICollection<Sertifika> Sertifika { get; set; }
    }
}
