using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2.Entities
{
    class LichSuHocTap:Person
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public string IdLs { get; set; }

        public string Lop { get; set; }
        /// <summary>
        /// Họ
        /// </summary>
        public string Truong { get; set; }
        /// <summary>
        /// Ngày sinh DOB = Date of Birth
        /// </summary>
        public double Diem { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public string HanhKiem { get; set; }
        /// <summary>
        /// Quê quán
        /// </summary>


        /// <summary>
        /// Lấy toàn bộ danh sách sinh viên trong CSDL
        /// (MockData)
        /// </summary>
        /// <returns>
        /// Danh sách sinh viên
        /// </returns>
        public static List<LichSuHocTap> GetList()
        {
            var ls = new List<LichSuHocTap>();
            ls.Add(new LichSuHocTap
            {
                IdLs = "1",
                Id = "1",
                FirstName = "Dũng",
                LastName = "Nguyễn",
                Sex = EGioiTinh.Nam,
                Lop = "6",
                Truong = "Xuân Phú",
                Diem = 8.5,
                HanhKiem = "Giỏi"
            });
            ls.Add(new LichSuHocTap
            {
                IdLs = "2",
                Id = "2",
                FirstName = "Bình ",
                LastName = "Nguyễn",
                Sex = EGioiTinh.Nam,
                Lop = "3",
                Truong = "Lê Lợi",
                Diem = 6.5,
                HanhKiem = "Khá"
            });
            ls.Add(new LichSuHocTap
            {
                IdLs = "3",
                Id = "3",
                FirstName = "Bình ",
                LastName = "Nguyễn",
                Sex = EGioiTinh.Nam,
                Lop = "3",
                Truong = "Lê Lợi",
                Diem = 6.5,
                HanhKiem = "Khá"
            });
            ls.Add(new LichSuHocTap
            {
                IdLs = "4",
                Id = "4",
                FirstName = "Bình ",
                LastName = "Nguyễn",
                Sex = EGioiTinh.Nam,
                Lop = "3",
                Truong = "Lê Lợi",
                Diem = 6.5,
                HanhKiem = "Khá"
            });


            return ls;
        }
        /// <summary>
        /// Lấy một sinh viên từ CSDL
        /// </summary>
        /// <param name="id">Mã sinh viên cần lấy</param>
        /// <returns>
        /// Sinh viên có mã tương ứng hoặc null nếu không tìm thấy
        /// </returns>
        public static LichSuHocTap Get(string id)
        {
            var dbLSHT = GetList();
            //Linq to SQL
            //Lamda expression
            var LSHT = dbLSHT.Where(p => p.Id == id).FirstOrDefault();
            return LSHT;
        }

    }
 

}
