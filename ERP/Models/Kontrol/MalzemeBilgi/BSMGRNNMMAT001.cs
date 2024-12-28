using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.MalzemeBilgi
{
    //malzeme tipleri
    public class BSMGRNNMMAT001
    {
        [Key]
        [MaxLength(4)]
        public required string DOCTYPE { get; set; } //Malzeme tipi
        [MaxLength(80)]
        public required string DOCTYPETEXT { get; set; } //mal tip açıklaması
        public required int ISPASSIVE { get; set; }
        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        [ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property



    }
}
