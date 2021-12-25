using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTap.DAL;
using ThucTap.ViewModel;

namespace ThucTap
{
    public partial class frmThemSv : Form
    {
        SinhvienViewModel SinhVien;
        public frmThemSv()
        {
            InitializeComponent();
            this.SinhVien = SinhVien;
            if(SinhVien == null)
            {
                this.Text = "Thêm mới thành công";
            }
            else
            {

                this.Text = "Cập nhật dữ liệu";
                textBox1.Text = SinhVien.HoTen;
                textBox2.Text = SinhVien.Email;
                textBox3.Text = SinhVien.Nganh;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var sinhVien = textBox1.Text;
            var sinhVien2 = textBox2.Text;
            var sinhVien3 = textBox3.Text;
            QLThucTap model = new QLThucTap();
            var lh = model.SinhViens.Where(t => t.HoTen == sinhVien.ToString()).FirstOrDefault();

            if(lh != null)
            {
                MessageBox.Show(" sinh viên đã tồn tại ", "Chú ý");
                return;
            }
            else
            {
                lh = new SinhVien
                {
                    HoTen = sinhVien,
                    Email = sinhVien2,
                    Nganh = sinhVien3

                };
                model.SinhViens.Add(lh);
                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show(" thêm thành công");

            }
        }
    }
}
