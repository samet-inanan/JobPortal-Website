using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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
