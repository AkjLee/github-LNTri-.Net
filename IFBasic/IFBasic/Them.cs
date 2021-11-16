using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IFBasic;
using IFBasic.Dal;
using IFBasic.BLL;
using IFBasic.Viewmodel;

namespace IFBasic
{
    public partial class Them : Form
    {
        LophocViewmodel lopHoc;

        public Them(LophocViewmodel lophoc = null)
        {
            InitializeComponent();
            this.lopHoc = lopHoc;
            if (lopHoc == null)
            {
                //Thêm mới lớp học
                this.Text = "Thêm mới lớp học";

            }
            else
            {
                //Cập nhật lớp học
                this.Text = "Cập nhật dữ liệu";
                txtbTenlop.Text = lopHoc.Name;
            }

        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tenLop = txtbTenlop.Text;
            if (string.IsNullOrEmpty(tenLop))
            {
                // MessageBox.Show("Vui lòng nhập tên lớp");
                errorProvider1.SetError(txtbTenlop, "Vui lòng nhập tên lớp");
                return;
            }
            QLSinhvienModel model = new QLSinhvienModel();
            if (lopHoc == null)
            {
                //Thêm mới
                
                var lh = model.Lophocs.Where(t => t.Name == tenLop).FirstOrDefault();
                 //   lh = model.Lophocs.Where(m => m.Sinhviens == soluong).FirstOrDefault(); thêm số lượng (Đang lỗi)
                if (lh != null)
                {
                    MessageBox.Show("Tên lớp trùng", "Chú ý");
                    return;
                }
                else
                {
                    lh = new Lophoc
                    {
                        Name = tenLop
                    };
                    model.Lophocs.Add(lh);
                    model.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                //Cập nhật
                var lh = model.Lophocs.Where(t => t.ID != lopHoc.ID && t.Name == tenLop).FirstOrDefault();
                if(lh != null)
                {
                    MessageBox.Show("Tên lớp trùng", "Chú ý");
                    return;
                }
                else
                {
                    lh = model.Lophocs.Where(t => t.ID == lopHoc.ID).FirstOrDefault();
                    lh.Name = tenLop;
                    model.SaveChanges();
                    DialogResult = DialogResult.OK;
                }

            }
        }
    }
}
