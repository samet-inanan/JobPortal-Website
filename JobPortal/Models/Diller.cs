using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class Diller
    {
        [Key]
        [Column("DillerID")]
        public int DillerId { get; set; }
        [Column("PersonelID")]
        public int? PersonelId { get; set; }
        [StringLength(150)]
        public string DilAd { get; set; }
        [StringLength(50)]
        public string DilYeterlilik { get; set; }

        [ForeignKey(nameof(PersonelId))]
        [InverseProperty("Diller")]
        public virtual Personel Personel { get; set; }
    }
}
