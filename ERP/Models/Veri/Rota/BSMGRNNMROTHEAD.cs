using ERP.Models.Kontrol.Genel;
using ERP.Models.Veri.Malzeme;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Veri.UrunAgac;
using ERP.Models.Veri.IsMerkez;
using ERP.Models.Kontrol.MalzemeBilgi;
using ERP.Models.Kontrol.RotaBilgi;

namespace ERP.Models.Veri.Rota
{
    //rota başlık bilgileri
    public class BSMGRNNMROTHEAD
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [Key]
        [MaxLength(4)]
        public required string ROTDOCNUM { get; set; } //rota numarası
        [MaxLength(4)]
        public required string ROTDOCTYPE { get; set; } //rota tipi
        public DateTime ROTDOCFROM { get; set; } //geçerlilik başlangıç
        public DateTime ROTDOCUNTIL { get; set; }
        public required string DRAWNUM { get; set; } //çizim no
        public required string MATDOCTYPE { get; set; } //malzeme tipi
        public required string MATDOCNUM { get; set; } //malzeme kodu
        public int OPRNUM { get; set; } //operasyon numarası
        public required string WCMDOCTYPE { get; set; } //iş merkezi tipi
        public required string WCMDOCNUM { get; set; } //iş merkezi numarası
        public required double SETUPTIME { get; set; }
        public required double MACHINETIME { get; set; }
        public required double LABOURTIME { get; set; }
        public required string BOMDOCNUM { get; set; } //ürün ağacı kod
        public required string BOMDOCTYPE { get; set; } //ürün ağacı numara
        public int CONTENTNUM { get; set; } //içerik no
        public string COMPONENT { get; set; } //bileşen kodu
        public double QUANTITY { get; set; } 
        public required int ISDELETED { get; set; }
        public required int ISPASSIVE { get; set; }

        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; }
        public virtual BSMGRNNMROT001? FROTDOCTYPE { get; set; }
        public virtual BSMGRNNMMATHEAD? FMATDOCNUM { get; set; }
        public virtual BSMGRNNMMATHEAD? FMATDOCTYPE { get; set; }
        public virtual BSMGRNNMWCMHEAD? FWCMDOCTYPE { get; set; }
        public virtual BSMGRNNMWCMHEAD? FWCMDOCNUM { get; set; }
        public virtual BSMGRNNMBOMHEAD? FBOMDOCNUM { get; set; } 
        public virtual BSMGRNNMBOMHEAD? FBOMDOCTYPE { get; set; } 

    }
}
