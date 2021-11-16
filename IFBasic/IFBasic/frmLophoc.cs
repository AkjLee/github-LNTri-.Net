using IFBasic.BLL;
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

namespace IFBasic
{
    public partial class frmLophoc : Form
    {
        public frmLophoc()
        {
            InitializeComponent();
            Naplophoc();

        }

        void Naplophoc()
        {
            var ls = LophocBLL.GetViewmodels();
           
            lophocViewmodelBindingSource.DataSource = ls;
            dataGridView1.DataSource = lophocViewmodelBindingSource;
            
        }

        private void Bttxoa_Click(object sender, EventArgs e)
        {
            var lopHoc = lophocViewmodelBindingSource.Current as LophocViewmodel;
            if (lopHoc != null)
            {
                var rs = MessageBox.Show("Ban có chắn chắn là muốn xóa không", "Thông báo",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ;

                if (rs == DialogResult.OK)
                {
                    if (LophocBLL.Delete(lopHoc.ID))
                    {
                        lophocViewmodelBindingSource.RemoveCurrent();
                        MessageBox.Show("Đã xóa thành công", "Thông báo");
                    }

                    else
                    {
                        MessageBox.Show("Xóa lớp không thành công", "Thông báo");
                    }

                }
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            /*Them fm = new Them();
            fm.Show();*/
            //this.Hide();

            var f = new Them();
            var rs = f.ShowDialog();
            if(rs == DialogResult.OK)
            {
                Naplophoc();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
             var lopHoc = lophocViewmodelBindingSource.Current as LophocViewmodel;
             if (lopHoc != null)
             {
                  var f = new Them(lopHoc);
                  var rs = f.ShowDialog();
                  if (rs == DialogResult.OK)
                  {
                      Naplophoc();
                  }
             }
            
        }
    }
}
