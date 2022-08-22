using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class IsBasvuruDurumu
    {
        public IsBasvuruDurumu()
        {
            IsBasvuru = new HashSet<IsBasvuru>();
        }

        [Key]
        [Column("IsBasvuruDurumuID")]
        public int IsBasvuruDurumuId { get; set; }
        [Column("IsBasvuruDurumu")]
        [StringLength(150)]
        public string IsBasvuruDurumu1 { get; set; }

        [InverseProperty("IsBasvuruDurumu")]
        public virtual ICollection<IsBasvuru> IsBasvuru { get; set; }
    }
}
