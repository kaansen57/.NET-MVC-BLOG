namespace MvcSinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Makale")]
    public partial class Makale
    {
        public Makale()
        {
            Yorums = new HashSet<Yorum>();
            Etikets = new HashSet<Etiket>();
        }

        public int MakaleId { get; set; }

        [StringLength(500)]
        public string Baslik { get; set; }

        public string Icerik { get; set; }

        [Column("Foto ")]
        [StringLength(500)]
        public string Foto { get; set; }

        public DateTime? Tarih { get; set; }

        public int? KategoriId { get; set; }

        public int? UyeId { get; set; }

        public int? Okunma { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Uye Uye { get; set; }

        public virtual ICollection<Yorum> Yorums { get; set; }

        public virtual ICollection<Etiket> Etikets { get; set; }
    }
}
