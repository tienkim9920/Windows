namespace BT1_LAB5
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
            this.txtInputX = new System.Windows.Forms.TextBox();
            this.txtInputY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputKQ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số Hạng X: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Lũy Thừa Y:";
            // 
            // txtInputX
            // 
            this.txtInputX.Location = new System.Drawing.Point(225, 76);
            this.txtInputX.Name = "txtInputX";
            this.txtInputX.Size = new System.Drawing.Size(139, 20);
            this.txtInputX.TabIndex = 2;
            // 
            // txtInputY
            // 
            this.txtInputY.Location = new System.Drawing.Point(225, 141);
            this.txtInputY.Name = "txtInputY";
            this.txtInputY.Size = new System.Drawing.Size(139, 20);
            this.txtInputY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết Quả :";
            // 
            // InputKQ
            // 
            this.InputKQ.AutoSize = true;
            this.InputKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputKQ.Location = new System.Drawing.Point(232, 205);
            this.InputKQ.Name = "InputKQ";
            this.InputKQ.Size = new System.Drawing.Size(16, 16);
            this.InputKQ.TabIndex = 5;
            this.InputKQ.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thực Hiện Phép Tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputY);
            this.Controls.Add(this.txtInputX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputX;
        private System.Windows.Forms.TextBox txtInputY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InputKQ;
        private System.Windows.Forms.Button button1;
    }
}

