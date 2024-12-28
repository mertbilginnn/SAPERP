using ERP.Models.Kontrol.Genel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.UrunAgac
{
    //urun agacı tipleri
    public class BSMGRNNMBOM001
    {
        [Key]
        [MaxLength(4)]
        public required string DOCTYPE { get; set; } //ÜRÜN AĞACI TİPİ
        [MaxLength(80)]
        public required string DOCTYPETEXT { get; set; }
        public required int ISPASSIVE { get; set; }

        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        [ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property


    }
}
