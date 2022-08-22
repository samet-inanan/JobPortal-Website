using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
