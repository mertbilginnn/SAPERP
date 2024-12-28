using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.RotaBilgi
{
    //operasyon kodları
    public class BSMGRNNMOPR001
    {
        [Key]
        [MaxLength(4)]
        public required string DOCTYPE { get; set; }
        [MaxLength(80)]
        public required string DOCTYPETEXT { get; set; }
        public required int ISPASSIVE { get; set; }

        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        [ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property

    }
}
