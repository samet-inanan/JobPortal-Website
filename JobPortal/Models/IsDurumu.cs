using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [InverseProperty("IsDurumu")]
        public virtual ICollection<IsIlani> IsIlani { get; set; }
    }
}
