using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testapp1.Entilien;

namespace Userfrom
{
    public partial class Userfrom : Form
    {
        public Userfrom()
        {
            InitializeComponent();
        }

        Student student;

        public object EGender { get; }

        public Userfrom(String idStudent = "1")
        {
            InitializeComponent();
            student = Student.Get(idStudent);
            if(student == null)
            {
                MessageBox.Show($"Khong tin thay Student co ma la {idStudent}", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Cach 1
                ttHoten.Text = $"{student.LastName} {student.FirsName}";
                //cach 2
                ttHoten.Text = student.FullName;
                ttNoisinh.Text = student.PDB;
                ttQuequan.Text = student.HomeTown;
                dtpNgaySinh.Value = student.DDB;

                if (student.Gender == EGender.Nam)
                    cbNam.Checked = true;
                else if (student.Gender == EGender.Nu)
                    cbNu.Checked = true;
                else
                    cbKhac.Checked = true;
            }
        }
    }
}
