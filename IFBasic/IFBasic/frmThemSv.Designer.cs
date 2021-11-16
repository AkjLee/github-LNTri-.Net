
namespace IFBasic
{
    partial class frmThemSv
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bttXacnhan = new System.Windows.Forms.Button();
            this.btthuy = new System.Windows.Forms.Button();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.txtNane = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNoisinh = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ddttime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nơi sinh";
            // 
            // bttXacnhan
            // 
            this.bttXacnhan.Location = new System.Drawing.Point(166, 196);
            this.bttXacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.bttXacnhan.Name = "bttXacnhan";
            this.bttXacnhan.Size = new System.Drawing.Size(100, 28);
            this.bttXacnhan.TabIndex = 6;
            this.bttXacnhan.Text = "Xác nhận";
            this.bttXacnhan.UseVisualStyleBackColor = true;
            this.bttXacnhan.Click += new System.EventHandler(this.bttXacnhan_Click);
            // 
            // btthuy
            // 
            this.btthuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btthuy.Location = new System.Drawing.Point(274, 196);
            this.btthuy.Margin = new System.Windows.Forms.Padding(4);
            this.btthuy.Name = "btthuy";
            this.btthuy.Size = new System.Drawing.Size(100, 28);
            this.btthuy.TabIndex = 7;
            this.btthuy.Text = "Hủy";
            this.btthuy.UseVisualStyleBackColor = true;
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(112, 22);
            this.txtIdStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(260, 23);
            this.txtIdStudent.TabIndex = 9;
            // 
            // txtNane
            // 
            this.txtNane.Location = new System.Drawing.Point(112, 54);
            this.txtNane.Margin = new System.Windows.Forms.Padding(4);
            this.txtNane.Name = "txtNane";
            this.txtNane.Size = new System.Drawing.Size(260, 23);
            this.txtNane.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(112, 86);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(260, 23);
            this.txtLastName.TabIndex = 11;
            // 
            // txtNoisinh
            // 
            this.txtNoisinh.Location = new System.Drawing.Point(112, 117);
            this.txtNoisinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoisinh.Name = "txtNoisinh";
            this.txtNoisinh.Size = new System.Drawing.Size(260, 23);
            this.txtNoisinh.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ddttime
            // 
            this.ddttime.Location = new System.Drawing.Point(112, 147);
            this.ddttime.Name = "ddttime";
            this.ddttime.Size = new System.Drawing.Size(262, 23);
            this.ddttime.TabIndex = 14;
            this.ddttime.ValueChanged += new System.EventHandler(this.ddttime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày sinh";
            // 
            // frmThemSv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btthuy;
            this.ClientSize = new System.Drawing.Size(405, 253);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddttime);
            this.Controls.Add(this.txtNoisinh);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtNane);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.btthuy);
            this.Controls.Add(this.bttXacnhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemSv";
            this.ShowInTaskbar = false;
            this.Text = "frmThemSv";
            this.Load += new System.EventHandler(this.frmThemSv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttXacnhan;
        private System.Windows.Forms.Button btthuy;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.TextBox txtNane;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNoisinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker ddttime;
        private System.Windows.Forms.Label label1;
    }
}