using BaiTap2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class FormManageUser : Form
    {
        public FormManageUser()
        {
            InitializeComponent();
            var ls = LichSuHocTap.GetList();
            lichSuHocTapBindingSource.DataSource = ls;
            dgvSinhVien.DataSource = lichSuHocTapBindingSource;
   


        }

        private void FormManageUser_Load(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSinhVien.ReadOnly = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show(
                    "Bạn có chắc là muốn xóa sinh viên này không?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int rowIndex = dgvSinhVien.CurrentCell.RowIndex;
                    dgvSinhVien.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tên nhân viên cần xóa");
            }
        }
    }
}
