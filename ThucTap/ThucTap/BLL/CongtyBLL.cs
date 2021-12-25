using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThucTap.DAL;
using ThucTap.ViewModel;

namespace ThucTap.BLL
{
    class CongtyBLL
    {
        public static List<CongTy> GetList(String TenCongTy)
        {
            QLThucTap model = new QLThucTap();
            var ls = model.CongTies.Where(e => e.TenCongTy == TenCongTy).ToList();
            return ls;
        }
        public static List<CongtyViewModel> GetListViewModel()
        {
            QLThucTap model = new QLThucTap();
            var ls = model.CongTies.Select(e => new CongtyViewModel
            {
                MaCty = e.MaCty.ToString(),
                TenCongTy = e.TenCongTy,
                DiaChi = e.DiaChi,
                ThongTin = e.ThongTin,
            }).ToList();
            return ls;
        }

        public static bool Delete(String TenCongTy)
        {
            QLThucTap model = new QLThucTap();
            var congTy = model.CongTies.Where(e => e.TenCongTy == TenCongTy).FirstOrDefault();
            model.CongTies.Remove(congTy);
            model.SaveChanges();
            return true;
        }
    }
}
