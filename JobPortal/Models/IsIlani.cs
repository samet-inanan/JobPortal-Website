using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class IsIlani
    {
        public IsIlani()
        {
            IsBasvuru = new HashSet<IsBasvuru>();
        }

        [Key]
        [Column("IsIlaniID")]
        public int IsIlaniId { get; set; }
        [Column("KullaniciID")]
        public int KullaniciId { get; set; }
        [Column("SirketID")]
        public int SirketId { get; set; }
        [Column("IsKategoriID")]
        public int IsKategoriId { get; set; }
        [Required]
        [StringLength(500)]
        public string IsBaslik { get; set; }
        [Required]
        [StringLength(2000)]
        public string IsAciklama { get; set; }
        public int MinimumMaas { get; set; }
        public int OrtalamaMaas { get; set; }
        [Required]
        [StringLength(500)]
        public string Konum { get; set; }
        public int GerekliKisi { get; set; }
        [Column("IsZamaniID")]
        public int IsZamaniId { get; set; }
        [Column(TypeName = "date")]
        public DateTime IsTarihZaman { get; set; }
        [Column(TypeName = "date")]
        public DateTime UygulamaSonTarih { get; set; }
        [Column(TypeName = "date")]
        public DateTime SonTarih { get; set; }
        [Column("IsGerekliliklerID")]
        public int IsGerekliliklerId { get; set; }
        [Column("IsDurumuID")]
        public int IsDurumuId { get; set; }

        [ForeignKey(nameof(IsDurumuId))]
        [InverseProperty("IsIlani")]
        public virtual IsDurumu IsDurumu { get; set; }
        [ForeignKey(nameof(IsDurumuId))]
        [InverseProperty(nameof(IsZamani.IsIlani))]
        public virtual IsZamani IsDurumuNavigation { get; set; }
        [ForeignKey(nameof(IsGerekliliklerId))]
        [InverseProperty("IsIlani")]
        public virtual IsGereklilikler IsGereklilikler { get; set; }
        [ForeignKey(nameof(IsKategoriId))]
        [InverseProperty("IsIlani")]
        public virtual IsKategori IsKategori { get; set; }
        [ForeignKey(nameof(KullaniciId))]
        [InverseProperty("IsIlani")]
        public virtual Kullanici Kullanici { get; set; }
        [ForeignKey(nameof(SirketId))]
        [InverseProperty("IsIlani")]
        public virtual Sirket Sirket { get; set; }
        [InverseProperty("IsIlani")]
        public virtual ICollection<IsBasvuru> IsBasvuru { get; set; }
    }
}
