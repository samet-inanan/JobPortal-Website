using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class IsBasvuru
    {
        [Key]
        [Column("IsBasvuruID")]
        public int IsBasvuruId { get; set; }
        [Column("PersonelID")]
        public int PersonelId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IsBasvuruTarih { get; set; }
        [Column("IsBasvuruDurumuID")]
        public int IsBasvuruDurumuId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IsBasvuruDurumuGuncelTarih { get; set; }
        [Required]
        [StringLength(1000)]
        public string IsBasvuruDurumuNedeni { get; set; }
        [Column("IsIlaniID")]
        public int IsIlaniId { get; set; }

        [ForeignKey(nameof(IsBasvuruDurumuId))]
        [InverseProperty("IsBasvuru")]
        public virtual IsBasvuruDurumu IsBasvuruDurumu { get; set; }
        [ForeignKey(nameof(IsIlaniId))]
        [InverseProperty("IsBasvuru")]
        public virtual IsIlani IsIlani { get; set; }
        [ForeignKey(nameof(PersonelId))]
        [InverseProperty("IsBasvuru")]
        public virtual Personel Personel { get; set; }
    }
}
