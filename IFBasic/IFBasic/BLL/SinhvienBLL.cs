using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFBasic.Dal;
using IFBasic.Viewmodel;

namespace IFBasic.BLL
{
    internal class SinhvienBLL
    {
        private static long? malop;

        public static List<Sinhvien> GetList(long maLop)
        {
            QLSinhvienModel model = new QLSinhvienModel();
            var ls = model.Sinhviens.Where(e => e.IDLophoc == maLop).ToList();
            return ls;
           
        }

        public static int Count (long maLop)
        {
            QLSinhvienModel model = new QLSinhvienModel();
            var total = model.Sinhviens.Where(e =>e.IDLophoc == maLop).Count();
            return 0;
        }

        public static List<SinhvienViewmodel> GetViewmodels()
        {
            QLSinhvienModel model = new QLSinhvienModel();
            var ls = model.Sinhviens.Select(e => new SinhvienViewmodel
            {
               
               // ID = e.ID,
               
                IDStudent = e.IDStudent,
                FistName = e.FistName,
                LastName = e.LastName,
                DOB = (DateTime)e.DOB,
                POB = e.POB,
                
            }).ToList();
            return ls;

        }
        public static bool Delete(string id)
        {
            QLSinhvienModel model = new QLSinhvienModel();
            var sinhVien = model.Sinhviens.Where(e => e.IDStudent == id).FirstOrDefault();
            
                model.Sinhviens.Remove(sinhVien);
                model.SaveChanges();
            return true;

        }
    }
}
