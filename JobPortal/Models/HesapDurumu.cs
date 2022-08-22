using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class HesapDurumu
    {
        public HesapDurumu()
        {
            Kullanici = new HashSet<Kullanici>();
        }

        [Key]
        [Column("HesapDurumuID")]
        public int HesapDurumuId { get; set; }
        [Required]
        [Column("HesapDurumu")]
        [StringLength(150)]
        public string HesapDurumu1 { get; set; }

        [InverseProperty("HesapDurumu")]
        public virtual ICollection<Kullanici> Kullanici { get; set; }
    }
}
