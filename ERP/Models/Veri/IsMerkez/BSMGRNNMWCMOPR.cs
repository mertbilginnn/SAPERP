using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models.Veri.IsMerkez
{
    //iş merkezi- operasyon kodları
    public class BSMGRNNMWCMOPR
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        [ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property

        [Key]
        [MaxLength(4)]
        public required string WCMDOCNUM { get; set; }
        [MaxLength(25)]
        public required string WCMDOCTYPE { get; set; }
        public DateTime WCMDOCFROM { get; set; }
        public DateTime WCMDOCUNTIL { get; set; }
        public string OPRDOCTYPE { get; set; }
    }
}
