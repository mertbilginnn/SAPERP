using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Veri.Malzeme
{
    //malzeme açıklamaları
    public class BSMGRNNMMATTEXT
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        //[ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property

        [Key]
        [MaxLength(4)]
        public required string MATDOCNUM { get; set; }
        [MaxLength(25)]
        public required string MATDOCTYPE { get; set; }
        public DateTime MATDOCFROM { get; set; }
        public DateTime MATDOCUNTIL { get; set; }
        public required string LANCODE { get; set; } //dil kodu

        //[ForeignKey("LANCODE")]
        public virtual BSMGRNNMGEN002? FLANCODE { get; set; }
        public string MATSTEXT { get; set; } //malzeme kısa açıklama
        public string MATLTEXT { get; set; } //malzeme uzun açıklama

    }
}
