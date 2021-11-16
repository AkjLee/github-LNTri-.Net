using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IFBasic.Dal
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Lophoc> Lophocs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Sinhvien> Sinhviens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lophoc>()
                .HasMany(e => e.Sinhviens)
                .WithOptional(e => e.Lophoc)
                .HasForeignKey(e => e.IDLophoc);

            modelBuilder.Entity<Sinhvien>()
                .Property(e => e.IDStudent)
                .IsUnicode(false);
        }
    }
}
