using ERP.Models.Kontrol.Genel;
using ERP.Models.Veri.Malzeme;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ERP.Models.Veri.IsMerkez;

namespace ERP.Models.Veri.Rota
{
    //rota operasyon bilgileri
    public class BSMGRNNMROTOPRCONTENT
    {
        [MaxLength(4)]
        public required string COMCODE { get; set; } // Foreign Key

        //[ForeignKey("COMCODE")]
        public virtual BSMGRNNMGEN001? FCOMCODE { get; set; } // Navigation Property

        [Key]
        [MaxLength(4)]
        public required string ROTDOCNUM { get; set; }
        [MaxLength(25)]
        public required string ROTDOCTYPE { get; set; }
        public DateTime ROTDOCFROM { get; set; }
        public DateTime ROTDOCUNTIL { get; set; }
        public required string MATDOCNUM { get; set; }

        //[ForeignKey("MATDOCNUM")]
        public virtual BSMGRNNMMATHEAD? FMATDOCNUM { get; set; }
        public required string MATDOCTYPE { get; set; }

        //[ForeignKey("MATDOCTYPE")]
        public virtual BSMGRNNMMATHEAD? FMATDOCTYPE { get; set; }
        public int OPRNUM { get; set; }
        public required string WCMDOCTYPE { get; set; }

        //[ForeignKey("WCMDOCTYPE")]
        public virtual BSMGRNNMWCMHEAD? FWCMDOCTYPE { get; set; }
        public required string WCMDOCNUM { get; set; }

        //[ForeignKey("WCMDOCNUM")]
        public virtual BSMGRNNMWCMHEAD? FWCMDOCNUM { get; set; }
        public required string OPRDOCTYPE { get; set; }

        //[ForeignKey("OPRDOCTYPE")]
        public virtual BSMGRNNMWCMHEAD? FOPRDOCTYPE { get; set; }
        public double SETUPTIME { get; set; }
        public double MACHINETIME { get; set; }
        public double LABOURTIME { get; set; }

    }
}
