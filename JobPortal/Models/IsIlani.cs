using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column("IsID")]
        public int IsId { get; set; }
        public int GerekliKisi { get; set; }
        [Required]
        [StringLength(500)]
        public string Yeterlilik { get; set; }
        [Required]
        [StringLength(500)]
        public string MinimumDeneyim { get; set; }
        public int YasLimit { get; set; }
        [Required]
        [StringLength(50)]
        public string MedeniDurum { get; set; }
        [Column(TypeName = "date")]
        public DateTime BaslangicTarihi { get; set; }
        [Column(TypeName = "date")]
        public DateTime BitisTarihi { get; set; }
        [Column(TypeName = "date")]
        public DateTime ShortlistTarih { get; set; }
        [Column(TypeName = "date")]
        public DateTime MulakatTarih { get; set; }
        [Column("IsDurumuID")]
        public int IsDurumuId { get; set; }
        [Required]
        [StringLength(2000)]
        public string Aciklama { get; set; }
        [Column("IsKategoriID")]
        public int IsKategoriId { get; set; }

        [ForeignKey(nameof(IsDurumuId))]
        [InverseProperty("IsIlani")]
        public virtual IsDurumu IsDurumu { get; set; }
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
