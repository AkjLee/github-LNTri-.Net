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
    public partial class frmThemcongty : Form
    {
        CongtyViewModel Congty;
        public frmThemcongty()
        {
            InitializeComponent();
            this.Congty = Congty;
            if(Congty == null)
            {
                this.Text = "Thêm mới công ty";
            }
            else
            {
                this.Text = "Cập nhật dữ liệu";
                textBox1.Text = Congty.TenCongTy;
                textBox2.Text = Congty.DiaChi;
                textBox3.Text = Congty.ThongTin;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var congTy = textBox1.Text;
            var congTy2 = textBox2.Text;
            var congTy3 = textBox3.Text;
            QLThucTap model = new QLThucTap();
            var lh = model.CongTies.Where(t => t.TenCongTy == congTy.ToString()).FirstOrDefault();
            if (lh != null)
            {
                MessageBox.Show("Công ty đã tồn tại", "Thông báo");
                return;
            }
            else
            {
                lh = new CongTy
                {
                    TenCongTy = congTy,
                    DiaChi = congTy2,
                    ThongTin = congTy3,
                };
                model.CongTies.Add(lh);
                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
