using ERP.Models.Kontrol.Genel;
using ERP.Models.Veri.Malzeme;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Veri.UrunAgac;

namespace ERP.Models.Veri.Rota

{
    //rota ürün ağacı tüketim bilgileri
    public class BSMGRNNMROTBOMCONTENT
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        //[ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property

        [Key]
        [MaxLength(4)]
        public required string ROTDOCNUM { get; set; }
        [MaxLength(25)]
        public required string ROTDOCTYPE { get; set; }
        public DateTime ROTDOCFROM { get; set; }
        public DateTime ROTDOCUNTIL { get; set; }
        public required string MATDOCNUM { get; set; }

        //[ForeignKey("MATDOCNUM")]
        public virtual BSMGRNNMMATHEAD? FMATDOCNUM { get; set; }
        public required string MATDOCTYPE { get; set; }

        //[ForeignKey("MATDOCTYPE")]
        public virtual BSMGRNNMMATHEAD? FMATDOCTYPE { get; set; }
        public int OPRNUM { get; set; }
        public required string BOMDOCNUM { get; set; }

        //[ForeignKey("BOMDOCNUM")]
        public virtual BSMGRNNMBOMHEAD? FBOMDOCNUM { get; set; }
        public required string BOMDOCTYPE { get; set; }

        //[ForeignKey("BOMDOCTYPE")]
        public virtual BSMGRNNMBOMHEAD? FBOMDOCTYPE { get; set; }
        public int CONTENTNUM { get; set; }
        public string COMPONENT { get; set; }
        public double QUANTITY { get; set; }


    }
}
