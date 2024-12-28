using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.Genel
{
    //diller
    public class BSMGRNNMGEN002
    {
        [Key]
        public required string LANCODE { get; set; }
        public required string LANTEXT { get; set; }
        // Foreign Key alanı
        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        [ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property

    }
}
