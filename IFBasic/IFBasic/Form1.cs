using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IFBasic.BLL;
using IFBasic.Dal;
using IFBasic.Viewmodel;

namespace IFBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ls = LophocBLL.GetList();
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "Name";
            Naplophoc();
        }


        void Naplophoc()
        {
            var ls = SinhvienBLL.GetViewmodels();

            sinhvienBindingSource.DataSource = ls;
            dataGridView1.DataSource = sinhvienBindingSource;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lopHoc = comboBox1.SelectedItem as Lophoc;
            if (lopHoc != null)
            {
                var maLop = lopHoc.ID;
                var ls = SinhvienBLL.GetList(maLop);
                sinhvienBindingSource.DataSource = ls;
                dataGridView1.DataSource = sinhvienBindingSource;

                lbltongsosinhvien.Text = $"{ls.Count} Sinh viên";
               /* var total = SinhvienBLL.Count(maLop);
                lbltongsosinhvien.Text = $"{total} Sinh viên";*/
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            var sinhVien = sinhvienBindingSource.Current as SinhvienViewmodel;
            if (sinhVien != null)
            {
                SinhvienBLL.Delete(sinhVien.IDStudent);
                MessageBox.Show("Đã xóa thành công ", "Thông báo");
                Naplophoc();
            }
           
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            var f = new frmThemSv();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                Naplophoc();
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            var sinhVien = sinhvienBindingSource.Current as SinhvienViewmodel;
            if (sinhVien != null)
            {
                var f = new frmThemSv(/*sinhVien*/);
                var rs = f.ShowDialog();
                if(rs == DialogResult.OK)
                {
                    Naplophoc();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*           if (dataGridView1.SelectedRows.Count > 0)
                       {
                           string IDStudent = dataGridView1.SelectedRows[0].Cells[0].Value + String.Empty;
                           txt.Text = IDStudent;
                      }*/
       
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt.Text = dataGridView1.Rows[i].Cells[i].Value.ToString();


        }
    }
}
