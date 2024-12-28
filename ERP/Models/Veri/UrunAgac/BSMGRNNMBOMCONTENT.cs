using ERP.Models.Kontrol.Genel;
using ERP.Models.Veri.Malzeme;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Veri.UrunAgac
{
    //ürün ağacı içerik bilgileri
    public class BSMGRNNMBOMCONTENT
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        //[ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property

        [Key]
        [MaxLength(4)]
        public required string BOMDOCNUM { get; set; }
        [MaxLength(25)]
        public required string BOMDOCTYPE { get; set; }
        public DateTime BOMDOCFROM { get; set; }
        public DateTime BOMDOCUNTIL { get; set; }
        public required string MATDOCNUM { get; set; }

        //[ForeignKey("MATDOCNUM")]
        public virtual BSMGRNNMMATHEAD? FMATDOCNUM { get; set; }
        public required string MATDOCTYPE { get; set; }

        //[ForeignKey("MATDOCTYPE")]
        public virtual BSMGRNNMMATHEAD? FMATDOCTYPE { get; set; }
        public int CONTENTNUM { get; set; }
        public string COMPONENT { get; set; }
        public string COMPBOMDOCTYPE { get; set; }
        public string COMPBOMDOCNUM { get; set; }
        public double QUANTITY { get; set; }
    }
}
