using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JobPortal.Models
{
    public partial class KullaniciTipi
    {
        public KullaniciTipi()
        {
            Kullanici = new HashSet<Kullanici>();
        }

        [Key]
        [Column("KullaniciTipID")]
        public int KullaniciTipId { get; set; }
        [StringLength(150)]
        public string KullaniciTipAdi { get; set; }

        [InverseProperty("KullaniciTip")]
        public virtual ICollection<Kullanici> Kullanici { get; set; }
    }
}
