namespace MvcSinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Etiket")]
    public partial class Etiket
    {
        public Etiket()
        {
            Makales = new HashSet<Makale>();
        }

        public int EtiketId { get; set; }

        [StringLength(50)]
        public string EtiketAdi { get; set; }

        public virtual ICollection<Makale> Makales { get; set; }
    }
}
