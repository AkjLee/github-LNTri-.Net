namespace IFBasic.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        public int MaNV { get; set; }

        [Required]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        public int IDPer { get; set; }
    }
}
