using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTap.DAL;
using ThucTap.ViewModel;

namespace ThucTap.BLL
{
    internal class SinhVienBLL
    {
        public static List<SinhVien> GetList(String HoTen)
        {
            QLThucTap model = new QLThucTap();
            var ls = model.SinhViens.Where(e => e.HoTen == HoTen).ToList();
            return ls;
        }
        public static List<SinhvienViewModel> GetListViewModel()
        {
            QLThucTap model = new QLThucTap();
            var ls = model.SinhViens.Select(e => new SinhvienViewModel
            {
                MaSV = e.MaSV.ToString(),
                HoTen = e.HoTen,
                Email = e.Email,
                Nganh = e.Nganh,
            }).ToList();
            return ls;
        }

        public static bool Delete (String HoTen)
        {
            QLThucTap model = new QLThucTap();
            var sinhVien = model.SinhViens.Where(e => e.HoTen == HoTen).FirstOrDefault();
            model.SinhViens.Remove(sinhVien);
            model.SaveChanges();
            return true;
        }
    }
}
