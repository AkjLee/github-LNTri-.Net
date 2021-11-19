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
    public partial class FormUser : Form
    {
        Person person;
       
        public FormUser(string idPerson = "1")
        {
            InitializeComponent();
            person = Person.Get(idPerson);
            if (person != null)
            {
                //Cách 1
                txtHoTen.Text = $"{person.LastName} {person.FirstName}";
                //Cách 2
                txtHoTen.Text = person.FullName;
                dtDate.Value = person.DOB;
                if (person.Sex == EGioiTinh.Nam)
                {
                    rdNam.Checked = true;
                }

                else if (person.Sex == EGioiTinh.Nu)
                {
                    rdNu.Checked = true;
                }

                else
                {
                    rdKhac.Checked = true;
                }


                rtxQueQuan.Text = person.HomeTown;
            }
  

        }
   /*     public Person selectedPerson
        {
            get
            {
                var p = personBindingSource.Current as Person;
                return p;
            }
        }*/

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
     

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       /*     if (selectedPerson != null)
            {
                var f = new FromUser(selectedPerson.Id);
                f.Show();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File ảnh(*.png, *.jpg)|*.png;*.jpg";
            dialog.Title = "Chọn ảnh đại diện";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;
                picAvatar.ImageLocation = fileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            FormManageUser frm = new FormManageUser();
            frm.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackground = colorDlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDlg.Color;

            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            FormFaculty frm = new FormFaculty();
            frm.ShowDialog();
        }
    }
}
