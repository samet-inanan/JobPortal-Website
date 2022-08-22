using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class Is
    {
        [Key]
        [Column("IsID")]
        public int IsId { get; set; }
        [Column("IsKategoriID")]
        public int IsKategoriId { get; set; }
        [Required]
        [StringLength(1000)]
        public string IsBaslik { get; set; }
        [Required]
        [StringLength(3000)]
        public string IsGereklilikler { get; set; }
        [Required]
        [StringLength(3000)]
        public string IsDetaylar { get; set; }

        [ForeignKey(nameof(IsKategoriId))]
        [InverseProperty("Is")]
        public virtual IsKategori IsKategori { get; set; }
    }
}
