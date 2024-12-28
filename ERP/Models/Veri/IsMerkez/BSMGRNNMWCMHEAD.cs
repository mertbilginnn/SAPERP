using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Veri.Maliyet;
using ERP.Models.Kontrol.UrunAgac;
using ERP.Models.Kontrol.RotaBilgi;

namespace ERP.Models.Veri.IsMerkez
{
    //iş merkezleri
    public class BSMGRNNMWCMHEAD
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [Key]
        [MaxLength(4)]
        public required string WCMDOCNUM { get; set; } //İş Merkezi NO PK

        [MaxLength(4)]
        public required string WCMDOCTYPE { get; set; } //İŞ MERKEZİ TİPİ FK
        public DateTime WCMDOCFROM { get; set; }
        public DateTime WCMDOCUNTIL { get; set; }
        public string MAINWCMDOCTYPE { get; set; } //Ana İş Merkezi Tipi
        public string MAINWCMDOCNUM { get; set; }
        public required string CCMDOCNUM { get; set; }
        public required string CCMDOCTYPE { get; set; }
        public required double WORKTIME { get; set; }
        public required int ISDELETED { get; set; }
        public required int ISPASSIVE { get; set; }
        public string WCMSTEXT { get; set; } //İş Merkezi Kısa Açıklaması
        public string WCMLTWXT { get; set; }
        public required string LANCODE { get; set; }
        public string OPRDOCTYPE { get; set; }

        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; }
        public virtual BSMGRNNMWCM001? DOCTYPE { get; set; }
        public virtual BSMGRNNMCCMHEAD? FCCMDOCNUM { get; set; }
        public virtual BSMGRNNMCCMHEAD? FCCMDOCTYPE { get; set; }
        public virtual BSMGRNNMGEN002? FLANCODE { get; set; }
    }
}
