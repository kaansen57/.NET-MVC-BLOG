namespace MvcSinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yetki")]
    public partial class Yetki
    {
        public Yetki()
        {
            Uyes = new HashSet<Uye>();
        }

        public int YetkiId { get; set; }

        [Column("Yetki")]
        [StringLength(50)]
        public string Yetki1 { get; set; }

        public virtual ICollection<Uye> Uyes { get; set; }
    }
}
