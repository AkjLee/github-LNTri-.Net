using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                MessageBox.Show("Vui lòng nhập vào số ");
            }
            else
            {
                var n1 = int.Parse(txtNumber1.Text);
                var n2 = int.Parse(txtNumber2.Text);
                var sum = n1 + n2;
                lblKq.Text = "Kết quả:  " + sum.ToString();
            }
     
         
           

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {

            if (check() == true)
            {
                MessageBox.Show("Vui lòng nhập vào số ");
            }
            else
            {
                var n1 = int.Parse(txtNumber1.Text);
                var n2 = int.Parse(txtNumber2.Text);
                var sum = n1 - n2;
                lblKq.Text = "Kết quả:  " + sum.ToString();
            }

    
            

        }
        public bool check()
        {
            if (String.IsNullOrEmpty(txtNumber1.Text) || String.IsNullOrEmpty(txtNumber2.Text))
            {
                
                return true;
            
            }
            else
            {
                return false;
            }
      
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {

            if (check() == true)
            {
                MessageBox.Show("Vui lòng nhập vào số ");
            }
            else
            {
                var n1 = int.Parse(txtNumber1.Text);
                var n2 = int.Parse(txtNumber2.Text);
                var sum = n1 * n2;
                lblKq.Text = "Kết quả:  " + sum.ToString();
            }
           
          
            
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                MessageBox.Show("Vui lòng nhập vào số ");
            }
            else
            {
                var n1 = double.Parse(txtNumber1.Text);
                var n2 = double.Parse(txtNumber2.Text);
                var sum = n1 / n2;
                lblKq.Text = "Kết quả:  " + sum.ToString();
            }
        }
    }
}
