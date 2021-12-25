using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucTap.DAL
{
    public partial class QLThucTap : DbContext
    {
        public QLThucTap()
            : base("name=AppConnecSting")
        {
        }

        public virtual DbSet<CongTy> CongTies { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
