using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Veri.Maliyet
{
    public class BSMGRNNMCCMTEXT
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        //[ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property

        [Key]
        [MaxLength(4)]
        public required string CCMDOCNUM { get; set; }
        [MaxLength(25)]
        public required string CCMDOCTYPE { get; set; }
        public DateTime CCMDOCFROM { get; set; }
        public DateTime CCMDOCUNTIL { get; set; }
        public required string LANCODE { get; set; }

        //[ForeignKey("LANCODE")]
        public virtual BSMGRNNMGEN002? FLANCODE { get; set; }
        public string CCMSTEXT { get; set; }
        public string CCMLTEXT { get; set; }
    }
}
