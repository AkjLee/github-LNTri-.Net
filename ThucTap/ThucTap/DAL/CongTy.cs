namespace ThucTap.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongTy")]
    public partial class CongTy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongTy()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCty { get; set; }

        [StringLength(50)]
        public string TenCongTy { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string ThongTin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
