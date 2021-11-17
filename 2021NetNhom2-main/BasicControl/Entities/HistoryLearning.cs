using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userfrom.Entilien
{
    public class HistoryLearning
    {
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public int YearBegin { get; set; }
        public int YearEnd { get; set; }
        public float Mark { get; set; }
        public string Rank
        {
            get
            {
                if (Mark < 5)
                    return "Yếu";
                else if (Mark < 7)
                    return "Trung bình";
                else if (Mark < 8)
                    return "Khá";
                else if (Mark < 9)
                    return "Giỏi";
                else return "Xuất xắc";
            }
        }
        public static IList<HistoryLearning> GetList(String idStudent)
        {
            List<HistoryLearning> List = new List<HistoryLearning>();
            List.Add(new HistoryLearning
            {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Tiểu học Chi Lăng",
                YearBegin = 2006,
                YearEnd = 2011,
                Mark = 8
            });
            List.Add(new HistoryLearning
            {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Trung học Chi Lăng",
                YearBegin = 2011,
                YearEnd = 2015,
                Mark = 9
            });
            List.Add(new HistoryLearning
            {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Phổ thông Chi Lăng",
                YearBegin = 2015,
                YearEnd = 2018,
                Mark = 7
            });
            return List;
        }

    }
}
