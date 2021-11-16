using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace IFBasic
{
    public partial class Dangnhap : Form
    {
        public static string UserName = "";

        public Dangnhap()
        {
            InitializeComponent();
        }
        private SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5E92ANP\SQLEXPRESS;Initial Catalog=QLSinhvien;Integrated Security=True");
        private void bttĐongy_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sta = new SqlDataAdapter("select count(*) from textuser where  UserAccount=N'" + textuser.Text + "' and textpass =N'" + textpass.Text + "'", Con);
            DataTable dt = new DataTable();
            sta.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                SqlDataAdapter sta1 = new SqlDataAdapter("select UserName from textuser where  UserAccount=N'" + textuser.Text + "' and textpass =N'" + textpass.Text + "'", Con);
                DataTable dt1 = new DataTable();
                sta1.Fill(dt1);
                foreach (DataRow dr in dt1.Rows)
                {
                    UserName = dr["UserName"].ToString();

                }

             //   Billing b = new Billing();
              //  b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng ! ");
            }



            Con.Close();
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
