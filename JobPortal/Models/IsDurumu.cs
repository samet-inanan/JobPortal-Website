using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class IsDurumu
    {
        public IsDurumu()
        {
            IsIlani = new HashSet<IsIlani>();
        }

        [Key]
        [Column("IsDurumuID")]
        public int IsDurumuId { get; set; }
        [Required]
        [Column("IsDurumu")]
        [StringLength(150)]
        public string IsDurumu1 { get; set; }
        [StringLength(2000)]
        public string DurumMesaji { get; set; }

        [InverseProperty("IsDurumu")]
        public virtual ICollection<IsIlani> IsIlani { get; set; }
    }
}
