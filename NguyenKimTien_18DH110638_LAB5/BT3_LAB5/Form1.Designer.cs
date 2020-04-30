namespace BT3_LAB5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioNVKD = new System.Windows.Forms.RadioButton();
            this.radioNVSX = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtSoLuongHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KQLuongNV = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Họ Tên:";
            // 
            // radioNVKD
            // 
            this.radioNVKD.AutoSize = true;
            this.radioNVKD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNVKD.Location = new System.Drawing.Point(142, 176);
            this.radioNVKD.Name = "radioNVKD";
            this.radioNVKD.Size = new System.Drawing.Size(179, 20);
            this.radioNVKD.TabIndex = 2;
            this.radioNVKD.TabStop = true;
            this.radioNVKD.Text = "Nhân Viên Kinh Doanh";
            this.radioNVKD.UseVisualStyleBackColor = true;
            this.radioNVKD.CheckedChanged += new System.EventHandler(this.radioNVKD_CheckedChanged);
            // 
            // radioNVSX
            // 
            this.radioNVSX.AutoSize = true;
            this.radioNVSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNVSX.Location = new System.Drawing.Point(435, 176);
            this.radioNVSX.Name = "radioNVSX";
            this.radioNVSX.Size = new System.Drawing.Size(162, 20);
            this.radioNVSX.TabIndex = 3;
            this.radioNVSX.TabStop = true;
            this.radioNVSX.Text = "Nhân Viên Sản Xuất";
            this.radioNVSX.UseVisualStyleBackColor = true;
            this.radioNVSX.CheckedChanged += new System.EventHandler(this.radioNVSX_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lương Cơ Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Lương Hợp Đồng";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(275, 32);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(216, 22);
            this.txtMaNhanVien.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(275, 90);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(216, 22);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(161, 235);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(115, 22);
            this.txtLuongCoBan.TabIndex = 8;
            // 
            // txtSoLuongHD
            // 
            this.txtSoLuongHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongHD.Location = new System.Drawing.Point(161, 296);
            this.txtSoLuongHD.Name = "txtSoLuongHD";
            this.txtSoLuongHD.Size = new System.Drawing.Size(115, 22);
            this.txtSoLuongHD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số Lượng Sản Phẩm";
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongSP.Location = new System.Drawing.Point(455, 235);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.Size = new System.Drawing.Size(115, 22);
            this.txtSoLuongSP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng Lương Nhân Viên: ";
            // 
            // KQLuongNV
            // 
            this.KQLuongNV.AutoSize = true;
            this.KQLuongNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KQLuongNV.Location = new System.Drawing.Point(427, 362);
            this.KQLuongNV.Name = "KQLuongNV";
            this.KQLuongNV.Size = new System.Drawing.Size(16, 16);
            this.KQLuongNV.TabIndex = 13;
            this.KQLuongNV.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thực Hiện Tính Lương";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KQLuongNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoLuongSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuongHD);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioNVSX);
            this.Controls.Add(this.radioNVKD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioNVKD;
        private System.Windows.Forms.RadioButton radioNVSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtSoLuongHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label KQLuongNV;
        private System.Windows.Forms.Button button1;
    }
}

