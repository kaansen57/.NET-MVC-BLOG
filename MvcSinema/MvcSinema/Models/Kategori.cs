namespace MvcSinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kategori")]
    public partial class Kategori
    {
        public Kategori()
        {
            Makales = new HashSet<Makale>();
        }

        public int KategoriId { get; set; }

        [StringLength(50)]
        public string KategoriAdi { get; set; }

        public virtual ICollection<Makale> Makales { get; set; }
    }
}
