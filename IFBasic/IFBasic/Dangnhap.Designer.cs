
namespace IFBasic
{
    partial class Dangnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttHuy = new System.Windows.Forms.Button();
            this.bttĐongy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttHuy
            // 
            this.bttHuy.Location = new System.Drawing.Point(188, 147);
            this.bttHuy.Name = "bttHuy";
            this.bttHuy.Size = new System.Drawing.Size(75, 23);
            this.bttHuy.TabIndex = 0;
            this.bttHuy.Text = "Hủy";
            this.bttHuy.UseVisualStyleBackColor = true;
            this.bttHuy.Click += new System.EventHandler(this.bttHuy_Click);
            // 
            // bttĐongy
            // 
            this.bttĐongy.Location = new System.Drawing.Point(336, 147);
            this.bttĐongy.Name = "bttĐongy";
            this.bttĐongy.Size = new System.Drawing.Size(75, 23);
            this.bttĐongy.TabIndex = 1;
            this.bttĐongy.Text = "Đồng ý";
            this.bttĐongy.UseVisualStyleBackColor = true;
            this.bttĐongy.Click += new System.EventHandler(this.bttĐongy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(188, 105);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(223, 20);
            this.textpass.TabIndex = 4;
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(188, 59);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(223, 20);
            this.textuser.TabIndex = 5;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 210);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttĐongy);
            this.Controls.Add(this.bttHuy);
            this.Name = "Dangnhap";
            this.Text = "Dangnhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttHuy;
        private System.Windows.Forms.Button bttĐongy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textuser;
    }
}