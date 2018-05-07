namespace MvcSinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uye")]
    public partial class Uye
    {
        public Uye()
        {
            Makales = new HashSet<Makale>();
            Yorums = new HashSet<Yorum>();
        }

        public int UyeId { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Sifre { get; set; }

        [StringLength(50)]
        public string AdSoyad { get; set; }

        [StringLength(250)]
        public string Foto { get; set; }

        public int? YetkiId { get; set; }

        public virtual ICollection<Makale> Makales { get; set; }

        public virtual Yetki Yetki { get; set; }

        public virtual ICollection<Yorum> Yorums { get; set; }
    }
}
