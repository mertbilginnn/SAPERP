using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models.Kontrol.Genel
{
    //ülkeler
    public class BSMGRNNMGEN003
    {
        [Key]
        [MaxLength(4)]
        public required string COUNTRYCODE { get; set; }

        [MaxLength(80)]
        public required string COUNTRYNAME { get; set; }

    }
}
