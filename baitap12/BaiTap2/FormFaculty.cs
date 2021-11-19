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
    public partial class FormFaculty : Form
    {
        bool flag;
        public FormFaculty()
        {
            InitializeComponent();
     
            cmbKhoa.DataSource = Faculty.GetList();
            cmbKhoa.DisplayMember = "Name";
            cmbKhoa.ValueMember = "Id";



        }

        private void FormFaculty_Load(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   if (flag)
           // {
                var index = cmbKhoa.SelectedIndex;
                var item = cmbKhoa.SelectedItem as Faculty;
                   var lsperson = Person.GetList(item.Id);
                 dgvKhoa.DataSource = lsperson;
           // }
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
