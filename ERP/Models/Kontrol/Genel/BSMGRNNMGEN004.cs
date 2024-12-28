using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.Genel
{
    //şehirler
    public class BSMGRNNMGEN004
    {
        [Key]
        [MaxLength(3)]
        public required string CITYCODE { get; set; }
        public required string CITYTEXT { get; set; }

        [MaxLength(4)]
        public string? COUNTRYCODE { get; set; }

        //[ForeignKey("COUNTRYCODE")]
        public virtual BSMGRNNMGEN003? COUNTRY { get; set; }

    }
}
