using ERP.Models.Veri.Malzeme;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.Genel
{
    //firma kodları
    public class BSMGRNNMGEN001
    {
        [Key]
        [MaxLength(4)]
        public required string COMCODE { get; set; }
        [MaxLength(80)]
        public required string COMTEXT { get; set; }
        [MaxLength(80)]
        public required string ADRESS1 { get; set; }
        [MaxLength(80)]
        public string? ADRESS2 { get; set; }
        
        // Foreign Key alanları
        public required string? CITYCODE { get; set; }

        //[ForeignKey("CITYCODE")]
        public virtual BSMGRNNMGEN004? CITY { get; set; }
        public required string COUNTRYCODE { get; set; }

        //[ForeignKey("COUNTRYCODE")]
        public virtual BSMGRNNMGEN003? COUNTRY { get; set; }

    }
}
