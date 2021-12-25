using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ThucTap.DAL
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ThucTapViewModel")
        {
        }

        public virtual DbSet<CongTy> CongTies { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongTy>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.CongTy)
                .WillCascadeOnDelete(false);
        }
    }
}
