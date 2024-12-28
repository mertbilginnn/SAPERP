using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.Maliyet
{
    //maliyet merkezleri
    public class BSMGRNNMCCM001
    {
        [Key]
        [MaxLength(4)]
        public required string DOCTYPE { get; set; } //maliyet merkezi tipi
        [MaxLength(80)]
        public required string DOCTYPETEXT { get; set; }
        public required int ISPASSIVE { get; set; }

        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        [ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property


    }
}
