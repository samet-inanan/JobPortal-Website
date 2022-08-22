using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class IsKategori
    {
        public IsKategori()
        {
            IsIlani = new HashSet<IsIlani>();
            Personel = new HashSet<Personel>();
        }

        [Key]
        [Column("IsKategoriID")]
        public int IsKategoriId { get; set; }
        [Required]
        [Column("IsKategori")]
        [StringLength(350)]
        public string IsKategori1 { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        [InverseProperty("IsKategori")]
        public virtual ICollection<IsIlani> IsIlani { get; set; }
        [InverseProperty("IsKategori")]
        public virtual ICollection<Personel> Personel { get; set; }
    }
}
