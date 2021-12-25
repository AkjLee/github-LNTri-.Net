using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTap.BLL;
using ThucTap.DAL;
using ThucTap.ViewModel;

namespace ThucTap
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            NapCongty();
        }
        void NapCongty()
        {
            var ls = CongtyBLL.GetListViewModel();
            congtyBindingSource.DataSource = ls;
            dataGridView1.DataSource = congtyBindingSource;
        }
        public void get()
        {
            QLThucTap model = new QLThucTap();

            var rows = model.CongTies.Select(row => row);
            congtyBindingSource.DataSource = rows;
            dataGridView1.DataSource = congtyBindingSource;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var congTy = congtyBindingSource.Current as CongtyViewModel;
            if (congTy != null)
            {
                CongtyBLL.Delete(congTy.TenCongTy);
                MessageBox.Show("Đã xóa thành công", "Thông báo");
                NapCongty();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmThemcongty();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapCongty();
            }
        }

        int i;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            i = dataGridView1.CurrentRow.Index;
            lbl.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //     ID = lblText.Text.ToString();
            //  IDtest = ID;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (
          String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox1.Text))

            {
                MessageBox.Show("Vui lòng chọn thông tin cần chỉnh sửa");

            }
            else
            {
                QLThucTap model = new QLThucTap();
                var lh = model.CongTies.Where(t => t.TenCongTy == lbl.Text).FirstOrDefault();

                // Thêm mới

                lh.TenCongTy = textBox1.Text;
                lh.DiaChi = textBox2.Text;
                lh.ThongTin = textBox3.Text;
                model.CongTies.Add(lh);

                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Cập nhật thông tin công ty thành công");
                NapCongty();
            }
        }
    }
}
