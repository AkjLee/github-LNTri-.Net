
namespace IFBasic
{
    partial class Them
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
            this.txtbTenlop = new System.Windows.Forms.TextBox();
            this.txtbSl = new System.Windows.Forms.TextBox();
            this.bttThem = new System.Windows.Forms.Button();
            this.bttBoqua = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // txtbTenlop
            // 
            this.txtbTenlop.Location = new System.Drawing.Point(179, 33);
            this.txtbTenlop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbTenlop.Name = "txtbTenlop";
            this.txtbTenlop.Size = new System.Drawing.Size(315, 23);
            this.txtbTenlop.TabIndex = 4;
            // 
            // txtbSl
            // 
            this.txtbSl.Location = new System.Drawing.Point(179, 77);
            this.txtbSl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbSl.Name = "txtbSl";
            this.txtbSl.Size = new System.Drawing.Size(315, 23);
            this.txtbSl.TabIndex = 5;
            // 
            // bttThem
            // 
            this.bttThem.Location = new System.Drawing.Point(179, 137);
            this.bttThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(100, 28);
            this.bttThem.TabIndex = 6;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // bttBoqua
            // 
            this.bttBoqua.Location = new System.Drawing.Point(395, 137);
            this.bttBoqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttBoqua.Name = "bttBoqua";
            this.bttBoqua.Size = new System.Drawing.Size(100, 28);
            this.bttBoqua.TabIndex = 9;
            this.bttBoqua.Text = "Bỏ qua";
            this.bttBoqua.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 193);
            this.Controls.Add(this.bttBoqua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.txtbSl);
            this.Controls.Add(this.txtbTenlop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Them";
            this.Text = "Them";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbTenlop;
        private System.Windows.Forms.TextBox txtbSl;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Button bttBoqua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}