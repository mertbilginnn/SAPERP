using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Kontrol.RotaBilgi;
using ERP.Models.Kontrol.Maliyet;

namespace ERP.Models.Veri.Maliyet
{
    public class BSMGRNNMCCMHEAD
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } 

        [Key]
        [MaxLength(4)]
        public required string CCMDOCNUM { get; set; } // PK Maliyet Merkezi Kodu

        [MaxLength(4)]
        public required string CCMDOCTYPE { get; set; } // FK Maliyet Merkezi Tipi
        public DateTime CCMDOCFROM { get; set; }
        public DateTime CCMDOCUNTIL { get; set; }
        public string MAINCCMDOCNUM { get; set; }
        public string MAINCCMDOCTYPE { get; set; }  
        public int ISDELETED { get; set; }
        public int ISPASSIVE { get; set; }
        public required string LANCODE { get; set; }
        public string CCMSTEXT { get; set; }
        public string CCMLTEXT { get; set; }
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; }
        public virtual BSMGRNNMGEN002? FLANCODE { get; set; }
        public virtual BSMGRNNMCCM001? DOCTYPE { get; set; }
    }
}
