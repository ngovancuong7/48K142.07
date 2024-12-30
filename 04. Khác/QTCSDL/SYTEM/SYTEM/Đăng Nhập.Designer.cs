namespace SYTEM
{
    partial class Đăng_Nhập
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
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.b_DangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(105, 137);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(306, 27);
            this.txt_MatKhau.TabIndex = 1;
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Location = new System.Drawing.Point(105, 72);
            this.txt_TenTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(306, 27);
            this.txt_TenTK.TabIndex = 0;
            // 
            // b_DangNhap
            // 
            this.b_DangNhap.BackColor = System.Drawing.SystemColors.Highlight;
            this.b_DangNhap.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_DangNhap.ForeColor = System.Drawing.SystemColors.Control;
            this.b_DangNhap.Location = new System.Drawing.Point(105, 252);
            this.b_DangNhap.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.b_DangNhap.Name = "b_DangNhap";
            this.b_DangNhap.Size = new System.Drawing.Size(306, 53);
            this.b_DangNhap.TabIndex = 3;
            this.b_DangNhap.Text = "Đăng Nhập";
            this.b_DangNhap.UseVisualStyleBackColor = false;
            this.b_DangNhap.Click += new System.EventHandler(this.b_DangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(101, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(101, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // txt_MaNS
            // 
            this.txt_MaNS.Location = new System.Drawing.Point(105, 196);
            this.txt_MaNS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNS.Name = "txt_MaNS";
            this.txt_MaNS.Size = new System.Drawing.Size(306, 27);
            this.txt_MaNS.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(104, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã Nhân Sự";
            // 
            // Đăng_Nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(503, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaNS);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenTK);
            this.Controls.Add(this.b_DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Đăng_Nhập";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng_Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Button b_DangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaNS;
        private System.Windows.Forms.Label label3;
    }
}