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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapSinhvien();
        }
        void NapSinhvien()
        {
            var ls = SinhVienBLL.GetListViewModel();
            sinhvienBindingSource.DataSource = ls;
            dataGridView1.DataSource = sinhvienBindingSource;
        }
        public void get()
        {
            QLThucTap model = new QLThucTap();

            var rows = model.SinhViens.Select(row => row);
            sinhvienBindingSource.DataSource = rows;
            dataGridView1.DataSource = sinhvienBindingSource;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int i;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sinhVien = sinhvienBindingSource.Current as SinhvienViewModel;
            if (sinhVien != null)
            {
                SinhVienBLL.Delete(sinhVien.HoTen);
                MessageBox.Show("ĐÃ XÓA ThÀNH CÔNG", "Thông báo");
                NapSinhvien();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmThemSv();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapSinhvien();
            }
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
                var lh = model.SinhViens.Where(t => t.HoTen == lbl.Text).FirstOrDefault();
                //   var max = txtSDT.Text;

                /*    if (String.IsNullOrEmpty(cuaHang))
                    {
                        errorProvider1.SetError(txtTenCH, "Vui lòng nhập tên cửa hàng");
                        errorProvider1.SetError(txtDC, "Vui lòng nhập địa chỉ cửa hàng");
                        errorProvider1.SetError(txtSDT, "Vui lòng nhập số điện thoại");
                        return;
                    }
                */

                // Thêm mới

                lh.HoTen = textBox1.Text;
                lh.Email = textBox2.Text;
                lh.Nganh = textBox3.Text;
                model.SinhViens.Add(lh);

                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Cập nhật thông tin cửa hàng thành công");
                NapSinhvien();
            }
        }
    }
}
