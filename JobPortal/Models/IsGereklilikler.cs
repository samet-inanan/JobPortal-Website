using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class IsGereklilikler
    {
        public IsGereklilikler()
        {
            IsGerekliliklerDetay = new HashSet<IsGerekliliklerDetay>();
            IsIlani = new HashSet<IsIlani>();
        }

        [Key]
        [Column("IsGerekliliklerID")]
        public int IsGerekliliklerId { get; set; }
        [Required]
        [StringLength(100)]
        public string IsGerekliliklerBaslik { get; set; }
        [Column("IsIlaniID")]
        public int? IsIlaniId { get; set; }

        [InverseProperty("IsGereklilikler")]
        public virtual ICollection<IsGerekliliklerDetay> IsGerekliliklerDetay { get; set; }
        [InverseProperty("IsGereklilikler")]
        public virtual ICollection<IsIlani> IsIlani { get; set; }
    }
}
