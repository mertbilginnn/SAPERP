using ERP.Models.Kontrol.Genel;
using ERP.Models.Kontrol.Maliyet;
using ERP.Models.Kontrol.MalzemeBilgi;
using ERP.Models.Kontrol.RotaBilgi;
using ERP.Models.Kontrol.UrunAgac;
using ERP.Models.Veri.IsMerkez;
using ERP.Models.Veri.Maliyet;
using ERP.Models.Veri.Malzeme;
using ERP.Models.Veri.Rota;
using ERP.Models.Veri.UrunAgac;
using Microsoft.EntityFrameworkCore;

namespace ERP.Context
{
    public class AppDbContext: DbContext 
    {
        // Kontrol -> Genel
        public DbSet<BSMGRNNMGEN001> BSMGRNNMGEN001 { get; set; }
        public DbSet<BSMGRNNMGEN002> BSMGRNNMGEN002 { get; set; }
        public DbSet<BSMGRNNMGEN003> BSMGRNNMGEN003 { get; set; }
        public DbSet<BSMGRNNMGEN004> BSMGRNNMGEN004 { get; set; }
        public DbSet<BSMGRNNMGEN005> BSMGRNNMGEN005 { get; set; }

        // Kontrol -> Maliyet
        public DbSet<BSMGRNNMCCM001> BSMGRNNMCCM001 { get; set; }

        // Kontrol -> MalzemeBilgi
        public DbSet<BSMGRNNMMAT001> BSMGRNNMMAT001 { get; set; }

        // Kontrol -> RotaBilgi
        public DbSet<BSMGRNNMOPR001> BSMGRNNMOPR001 { get; set; }
        public DbSet<BSMGRNNMWCM001> BSMGRNNMWCM001 { get; set; }
        public DbSet<BSMGRNNMROT001> BSMGRNNMROT001 { get; set; }

        // Kontrol -> UrunAgac
        public DbSet<BSMGRNNMBOM001> BSMGRNNMBOM001 { get; set; }

        // Veri -> IsMerkez
        public DbSet<BSMGRNNMWCMHEAD> BSMGRNNMWCMHEAD { get; set; }
        //public DbSet<BSMGRNNMWCMOPR> BSMGRNNMWCMOPR { get; set; }
        //public DbSet<BSMGRNNMWCMTEXT> BSMGRNNMWCMTEXT { get; set; }

        // Veri -> Maliyet
        public DbSet<BSMGRNNMCCMHEAD> BSMGRNNMCCMHEAD { get; set; }
        //public DbSet<BSMGRNNMCCMTEXT> BSMGRNNMCCMTEXT { get; set; }

        // Veri -> Malzeme
        public DbSet<BSMGRNNMMATHEAD> BSMGRNNMMATHEAD { get; set; }
        //public DbSet<BSMGRNNMMATTEXT> BSMGRNNMMATTEXT { get; set; }

        // Veri -> Rota
        //public DbSet<BSMGRNNMROTBOMCONTENT> BSMGRNNMROTBOMCONTENT { get; set; }
        public DbSet<BSMGRNNMROTHEAD> BSMGRNNMROTHEAD { get; set; }
        //public DbSet<BSMGRNNMROTOPRCONTENT> BSMGRNNMROTOPRCONTENT { get; set; }

        // Veri -> UrunAgac
        //public DbSet<BSMGRNNMBOMCONTENT> BSMGRNNMBOMCONTENT { get; set; }
        public DbSet<BSMGRNNMBOMHEAD> BSMGRNNMBOMHEAD { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CITYCODE ile BSMGRNNMGEN004 ilişkisi
            modelBuilder.Entity<BSMGRNNMGEN001>()
                .HasOne(g => g.CITY) // Navigation Property
                .WithMany()
                .HasForeignKey(g => g.CITYCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // COUNTRYCODE ile BSMGRNNMGEN003 ilişkisi
            modelBuilder.Entity<BSMGRNNMGEN001>()
                .HasOne(g => g.COUNTRY) // Navigation Property
                .WithMany()
                .HasForeignKey(g => g.COUNTRYCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // COUNTRYCODE ile BSMGRNNMGEN003 ilişkisi
            modelBuilder.Entity<BSMGRNNMGEN004>()
                .HasOne(c => c.COUNTRY) // Navigation Property
                .WithMany()
                .HasForeignKey(c => c.COUNTRYCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMWCMHEAD>()
                .HasOne(w => w.FCOMCODE) // Navigation Property
                .WithMany() // BSMGRNNMGEN001 birden fazla iş merkezine sahip olabilir
                .HasForeignKey(w => w.COMCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            //WCM1 
            modelBuilder.Entity<BSMGRNNMWCMHEAD>()
                .HasOne(w => w.DOCTYPE) // Navigation Property
                .WithMany() // BSMGRNNMGEN001 birden fazla iş merkezine sahip olabilir
                .HasForeignKey(w => w.WCMDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // CCMDOCNUM ile BSMGRNNMCCMHEAD ilişkisi
            modelBuilder.Entity<BSMGRNNMWCMHEAD>()
                .HasOne(w => w.FCCMDOCNUM) // Navigation Property
                .WithMany() // BSMGRNNMCCMHEAD birden fazla iş merkezine sahip olabilir
                .HasForeignKey(w => w.CCMDOCNUM) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // CCMDOCTYPE ile BSMGRNNMCCMHEAD ilişkisi
            modelBuilder.Entity<BSMGRNNMWCMHEAD>()
                .HasOne(w => w.FCCMDOCTYPE) // Navigation Property
                .WithMany() // BSMGRNNMCCMHEAD birden fazla iş merkezine sahip olabilir
                .HasForeignKey(w => w.CCMDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı                                               

            // LANCODE ile BSMGRNNMGEN002 ilişkisi
            modelBuilder.Entity<BSMGRNNMWCMHEAD>()
                .HasOne(w => w.FLANCODE) // Navigation Property
                .WithMany() // BSMGRNNMGEN002 birden fazla BSMGRNNMWCMTEXT ile ilişkili olabilir
                .HasForeignKey(w => w.LANCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı
                                                    
            modelBuilder.Entity<BSMGRNNMCCMHEAD>()
                .HasOne(c => c.FCOMCODE) // Navigation Property
                .WithMany() 
                .HasForeignKey(c => c.COMCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            //CCM1 
            modelBuilder.Entity<BSMGRNNMCCMHEAD>()
                .HasOne(c => c.DOCTYPE) // Navigation Property
                .WithMany()
                .HasForeignKey(c => c.CCMDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // LANCODE ile BSMGRNNMGEN002 ilişkisi
            modelBuilder.Entity<BSMGRNNMCCMHEAD>()
                .HasOne(c => c.FLANCODE) // Navigation Property
                .WithMany() 
                .HasForeignKey(c => c.LANCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı
                                                    
            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                .HasOne(m => m.FCOMCODE) // Navigation Property
                .WithMany() // BSMGRNNMGEN001 birden fazla BSMGRNNMMATTEXT ile ilişkili olabilir
                .HasForeignKey(m => m.COMCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                .HasOne(m => m.FMATDOCTYPE) // Navigation Property
                .WithMany() 
                .HasForeignKey(m => m.MATDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                .HasOne(m => m.FROTDOCTYPE) // Navigation Property
                .WithMany() 
                .HasForeignKey(m => m.ROTDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                .HasOne(r => r.FBOMDOCNUM) // Navigation Property
                .WithMany()
                .HasForeignKey(r => r.BOMDOCNUM) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                .HasOne(r => r.FBOMDOCTYPE) // Navigation Property
                .WithMany()
                .HasForeignKey(r => r.BOMDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // LANCODE ile BSMGRNNMGEN002 ilişkisi
            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                .HasOne(m => m.FLANCODE) // Navigation Property
                .WithMany() // BSMGRNNMGEN002 birden fazla BSMGRNNMMATTEXT ile ilişkili olabilir
                .HasForeignKey(m => m.LANCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            //last ekleme
            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                 .HasOne(m => m.FSTUNIT)
                 .WithMany()
                 .HasForeignKey(m => m.STUNIT)
                 .OnDelete(DeleteBehavior.Restrict);

            // NWUNIT FK ile GEN005 ilişkilendirilmesi
            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                .HasOne(m => m.FNWUNIT)
                .WithMany()
                .HasForeignKey(m => m.NWUNIT)
                .OnDelete(DeleteBehavior.Restrict);

            // BWUNIT FK ile GEN005 ilişkilendirilmesi
            modelBuilder.Entity<BSMGRNNMMATHEAD>()
                .HasOne(m => m.FBWUNIT)
                .WithMany()
                .HasForeignKey(m => m.BWUNIT)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BSMGRNNMROTHEAD>()
                .HasOne(m => m.FCOMCODE) // Navigation Property
                .WithMany() // BSMGRNNMGEN001 
                .HasForeignKey(m => m.COMCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı
            
            //ROT001
            modelBuilder.Entity<BSMGRNNMROTHEAD>()
                .HasOne(m => m.FROTDOCTYPE) // Navigation Property
                .WithMany() 
                .HasForeignKey(m => m.ROTDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMROTHEAD>()
               .HasOne(r => r.FMATDOCNUM) // Navigation Property
               .WithMany()
               .HasForeignKey(r => r.MATDOCNUM) // Foreign Key
               .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMROTHEAD>()
               .HasOne(r => r.FMATDOCTYPE) // Navigation Property
               .WithMany()
               .HasForeignKey(r => r.MATDOCTYPE) // Foreign Key
               .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMROTHEAD>()
                .HasOne(r => r.FBOMDOCNUM) // Navigation Property
                .WithMany() 
                .HasForeignKey(r => r.BOMDOCNUM) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı
    
            modelBuilder.Entity<BSMGRNNMROTHEAD>()
                .HasOne(r => r.FBOMDOCTYPE) // Navigation Property
                .WithMany() 
                .HasForeignKey(r => r.BOMDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı
                                                  
            // WCMDOCTYPE ile BSMGRNNMWCMHEAD ilişkisi
            modelBuilder.Entity<BSMGRNNMROTHEAD>()
                .HasOne(r => r.FWCMDOCTYPE) // Navigation Property
                .WithMany() 
                .HasForeignKey(r => r.WCMDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // WCMDOCNUM ile BSMGRNNMWCMHEAD ilişkisi
            modelBuilder.Entity<BSMGRNNMROTHEAD>()
                .HasOne(r => r.FWCMDOCNUM) // Navigation Property
                .WithMany()
                .HasForeignKey(r => r.WCMDOCNUM) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMBOMHEAD>()
                .HasOne(b => b.DOCTYPE) // Navigation Property
                .WithMany() // BSMGRNNMBOM001 birden fazla BSMGRNNMBOMHEAD ile ilişkili olabilir
                .HasForeignKey(b => b.BOMDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            modelBuilder.Entity<BSMGRNNMBOMHEAD>()
                .HasOne(b => b.FCOMCODE) // Navigation Property
                .WithMany() // BSMGRNNMGEN001 birden fazla BSMGRNNMBOMHEAD ile ilişkili olabilir
                .HasForeignKey(b => b.COMCODE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // MATDOCNUM ile BSMGRNNMMATHEAD ilişkisi
            modelBuilder.Entity<BSMGRNNMBOMHEAD>()
                .HasOne(b => b.FMATDOCNUM) // Navigation Property
                .WithMany() // BSMGRNNMMATHEAD birden fazla BSMGRNNMBOMHEAD ile ilişkili olabilir
                .HasForeignKey(b => b.MATDOCNUM) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

            // MATDOCTYPE ile BSMGRNNMMATHEAD ilişkisi
            modelBuilder.Entity<BSMGRNNMBOMHEAD>()
                .HasOne(b => b.FMATDOCTYPE) // Navigation Property
                .WithMany() // BSMGRNNMMATHEAD birden fazla BSMGRNNMBOMHEAD ile ilişkili olabilir
                .HasForeignKey(b => b.MATDOCTYPE) // Foreign Key
                .OnDelete(DeleteBehavior.Restrict); // Silme davranışı

        }

    }
}
