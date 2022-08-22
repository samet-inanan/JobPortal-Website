using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortal.Models
{
    public partial class SimdikiIsDurumu
    {
        public SimdikiIsDurumu()
        {
            Personel = new HashSet<Personel>();
        }

        [Key]
        [Column("SimdikiIsDurumuID")]
        public int SimdikiIsDurumuId { get; set; }
        [Required]
        [Column("SimdikiIsDurumu")]
        [StringLength(150)]
        public string SimdikiIsDurumu1 { get; set; }

        [InverseProperty("SimdikiIsDurumu")]
        public virtual ICollection<Personel> Personel { get; set; }
    }
}
