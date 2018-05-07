namespace MvcSinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kampanyalar")]
    public partial class Kampanyalar
    {
        [Key]
        public int KampanyaId { get; set; }

        [StringLength(50)]
        public string Baslik { get; set; }

        [StringLength(500)]
        public string Icerik { get; set; }

        public DateTime? Tarih { get; set; }

        [StringLength(250)]
        public string Foto { get; set; }
    }
}
