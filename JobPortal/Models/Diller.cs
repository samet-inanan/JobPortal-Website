using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
