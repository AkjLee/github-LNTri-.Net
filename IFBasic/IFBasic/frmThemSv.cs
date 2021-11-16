using IFBasic.Viewmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IFBasic;
using IFBasic.BLL;
using IFBasic.Dal;


namespace IFBasic
{
    public partial class frmThemSv : Form
    {
        SinhvienViewmodel Sinhvien;
        public frmThemSv(/*SinhvienViewmodel sinhvien = null*/)
        {
            InitializeComponent();
            this.Sinhvien = Sinhvien;
            if (Sinhvien == null)
            {
                //Thêm mới lớp học
                this.Text = "Thêm mới lớp học";

            }
            else
            {
                //Cập nhật lớp học
                this.Text = "Cập nhật dữ liệu";
                //txtIdStudent.Text = sinhvien.IDStudent;
                txtLastName.Text = Sinhvien.LastName;
                txtNane.Text = Sinhvien.FistName;
                txtNoisinh.Text = Sinhvien.POB;
                DateTime ngaysinh = Convert.ToDateTime(ddttime.Text);

            }

        }

        private void bttXacnhan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var sinhVien = txtIdStudent.Text;
            var sinhVien2 = txtNane.Text;
            var sinhVien3 = txtLastName.Text;
            var sinhVien4 = txtNoisinh.Text;
            DateTime sinhVien5 = Convert.ToDateTime(ddttime.Text);
            //long sinhVien5 = txtid;

            if (string.IsNullOrEmpty(sinhVien))
            {
                // MessageBox.Show("Vui lòng nhập tên lớp");
                errorProvider1.SetError(txtIdStudent, "Vui lòng nhập tên lớp");
                errorProvider1.SetError(txtNane, "Vui lòng nhập tên sinh viên");
                errorProvider1.SetError(txtLastName, "Vui lòng nhập họ tên");
                errorProvider1.SetError(txtNoisinh, "Vui lòng nhập nơi sinh");
                errorProvider1.SetError(ddttime, "Vui lòng nhập id lớp");
                //errorProvider1.SetError(txtbSl, "Nhập số lượng lớp");
                return;
            }
            QLSinhvienModel model = new QLSinhvienModel();
            if (Sinhvien != null)
            {
                //Thêm mới

                var lh = model.Sinhviens.Where(t => t.IDStudent == sinhVien).FirstOrDefault();
                if (lh != null)
                {
                    MessageBox.Show("ID sinh viền trùng", "Chú ý");
                    return;
                }
                else
                {
                    lh = new Sinhvien
                    {
                       
                        IDStudent = sinhVien,
                        FistName = sinhVien2,
                        LastName = sinhVien3,
                        POB = sinhVien4,
                        DOB = sinhVien5
                    };
                    model.Sinhviens.Add(lh);
                    model.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                //Cập nhật
                var lh = model.Sinhviens.Where(t => t.IDStudent != Sinhvien.IDStudent && t.IDStudent == sinhVien).FirstOrDefault();
                if (lh != null)
                {
                    MessageBox.Show("ID sinh  viên  trùng", "Chú ý");
                    return;
                }
                else
                {
                    lh = model.Sinhviens.Where(t => t.IDStudent == Sinhvien.IDStudent).FirstOrDefault();
                    lh.IDStudent = sinhVien;
                    model.SaveChanges();
                    DialogResult = DialogResult.OK;
                }

            }
        }











        private void frmThemSv_Load(object sender, EventArgs e)
        {

        }

        private void ddttime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
