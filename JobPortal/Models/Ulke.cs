using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class Ulke
    {
        public Ulke()
        {
            Egitim = new HashSet<Egitim>();
            IsDeneyim = new HashSet<IsDeneyim>();
            Personel = new HashSet<Personel>();
        }

        [Key]
        [Column("UlkeID")]
        public int UlkeId { get; set; }
        [Required]
        [Column("Ulke")]
        [StringLength(150)]
        public string Ulke1 { get; set; }

        [InverseProperty("Ulke")]
        public virtual ICollection<Egitim> Egitim { get; set; }
        [InverseProperty("Ulke")]
        public virtual ICollection<IsDeneyim> IsDeneyim { get; set; }
        [InverseProperty("KullaniciNavigation")]
        public virtual ICollection<Personel> Personel { get; set; }
    }
}
