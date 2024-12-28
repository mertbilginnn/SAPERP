using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.Genel
{
    //ağırlık birimleri
    public class BSMGRNNMGEN005
    {
        [Key]
        [MaxLength(3)]
        public required string UNITCODE { get; set; } //Birim Kodu
        [MaxLength(80)]
        public required string UNITTEXT { get; set; } //Birim adı
        public required int ISMAINUNIT { get; set; } //Ana Ağırlık Birimi

        [MaxLength(3)]
        public required string MAINUNITCODE { get; set; } //Ana Birim Kodu

        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        [ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property


    }
}
