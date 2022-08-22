using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class IsZamani
    {
        public IsZamani()
        {
            IsIlani = new HashSet<IsIlani>();
        }

        [Key]
        [Column("IsZamaniID")]
        public int IsZamaniId { get; set; }
        [Required]
        [Column("IsZamani")]
        [StringLength(150)]
        public string IsZamani1 { get; set; }

        [InverseProperty("IsDurumuNavigation")]
        public virtual ICollection<IsIlani> IsIlani { get; set; }
    }
}
