
using ERP.Models.Kontrol.Genel;
using ERP.Models.Kontrol.MalzemeBilgi;
using ERP.Models.Kontrol.RotaBilgi;
using ERP.Models.Kontrol.UrunAgac;
using ERP.Models.Veri.UrunAgac;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Veri.Malzeme
{
    //malzeme temel bilgileri
    public class BSMGRNNMMATHEAD
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [Key]
        [MaxLength(4)]
        public required string MATDOCNUM { get; set; } //malzeme kodu

        [MaxLength(4)]
        public required string MATDOCTYPE { get; set; } //malzeme tipi
        public DateTime MATDOCFROM { get; set; } //geçerlilik
        public DateTime MATDOCUNTIL { get; set; } //geçer bitiş
        public int SUPPLYTYPE { get; set; } //tedarik tipi
        public string? STUNIT { get; set; } //malzeme stok birimi gen5den
        public double NETWEIGHT { get; set; } //net agırlık
        public string NWUNIT { get; set; } //net agırlık birimi
        public double BRUTWEIGHT { get; set; }  //brüt ağırlık
        public string BWUNIT { get; set; } //brut agırlık birimi
        public int ISBOM { get; set; } //ürün agacı var mı
        public required string BOMDOCNUM { get; set; }
        public required string BOMDOCTYPE { get; set; }
        public int ISROUTE { get; set; } //rota var mı
        [MaxLength(4)]
        public required string ROTDOCTYPE { get; set; } //rota tipi
        public string ROTDOCNUM { get; set; }  //rota numarası
        public int ISDELETED { get; set; }
        public int ISPASSIVE { get; set; }
        public required string LANCODE { get; set; } //dil kodu
        public string MATSTEXT { get; set; } //malzeme kısa açıklama
        public string MATLTEXT { get; set; } //malzeme uzun açıklama

        //nav properties

        public virtual BSMGRNNMGEN005? FSTUNIT { get; set; } // Stok Birimi
        public virtual BSMGRNNMGEN005? FNWUNIT { get; set; } // Net Ağırlık Birimi
        public virtual BSMGRNNMGEN005? FBWUNIT { get; set; } // Brüt Ağırlık Birimi
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; }
        public virtual BSMGRNNMMAT001? FMATDOCTYPE { get; set; }
        public virtual BSMGRNNMBOMHEAD? FBOMDOCNUM { get; set; } //ÜA KOD
        public virtual BSMGRNNMBOMHEAD? FBOMDOCTYPE { get; set; } //ÜRÜN AĞACI TİPİ
        public virtual BSMGRNNMGEN002? FLANCODE { get; set; }
        public virtual BSMGRNNMROT001? FROTDOCTYPE { get; set; }


    }
}
