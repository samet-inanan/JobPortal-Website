using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class IsGerekliliklerDetay
    {
        [Key]
        [Column("IsGerekliliklerDetayID")]
        public int IsGerekliliklerDetayId { get; set; }
        [Column("IsGerekliliklerID")]
        public int IsGerekliliklerId { get; set; }
        [Required]
        [Column("IsGerekliliklerDetay")]
        [StringLength(2000)]
        public string IsGerekliliklerDetay1 { get; set; }

        [ForeignKey(nameof(IsGerekliliklerId))]
        [InverseProperty("IsGerekliliklerDetay")]
        public virtual IsGereklilikler IsGereklilikler { get; set; }
    }
}
