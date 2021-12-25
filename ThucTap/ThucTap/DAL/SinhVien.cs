namespace ThucTap.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Nganh { get; set; }

        public int MaCty { get; set; }

        public virtual CongTy CongTy { get; set; }
    }
}
