using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class IsKategori
    {
        public IsKategori()
        {
            Is = new HashSet<Is>();
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
        public virtual ICollection<Is> Is { get; set; }
        [InverseProperty("IsKategori")]
        public virtual ICollection<IsIlani> IsIlani { get; set; }
        [InverseProperty("IsKategori")]
        public virtual ICollection<Personel> Personel { get; set; }
    }
}
