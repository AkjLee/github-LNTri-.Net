namespace IFBasic.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sinhvien")]
    public partial class Sinhvien
    {
        public long ID { get; set; }

        [StringLength(20)]
        public string IDStudent { get; set; }

        [StringLength(20)]
        public string FistName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(200)]
        public string POB { get; set; }

        public long? IDLophoc { get; set; }

        public virtual Lophoc Lophoc { get; set; }
    }
}
