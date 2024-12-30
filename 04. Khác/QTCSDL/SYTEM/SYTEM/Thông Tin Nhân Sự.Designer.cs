namespace SYTEM
{
    partial class frm_NhanSu
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.tx_TenNS = new System.Windows.Forms.TextBox();
            this.tx_SDT = new System.Windows.Forms.TextBox();
            this.tx_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.tx_NhanVien = new System.Windows.Forms.RadioButton();
            this.tx_QuanLy = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.LamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(287, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã Nhân Sự";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(287, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên Nhân Sự";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(287, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Số Điện Thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(287, 194);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ngày Sinh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(287, 296);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Chức Vụ";
            // 
            // txtMaNS
            // 
            this.txtMaNS.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNS.Location = new System.Drawing.Point(442, 85);
            this.txtMaNS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(257, 27);
            this.txtMaNS.TabIndex = 0;
            // 
            // tx_TenNS
            // 
            this.tx_TenNS.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_TenNS.Location = new System.Drawing.Point(443, 140);
            this.tx_TenNS.Margin = new System.Windows.Forms.Padding(4);
            this.tx_TenNS.Name = "tx_TenNS";
            this.tx_TenNS.Size = new System.Drawing.Size(257, 27);
            this.tx_TenNS.TabIndex = 1;
            // 
            // tx_SDT
            // 
            this.tx_SDT.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_SDT.Location = new System.Drawing.Point(442, 246);
            this.tx_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.tx_SDT.Name = "tx_SDT";
            this.tx_SDT.Size = new System.Drawing.Size(257, 27);
            this.tx_SDT.TabIndex = 4;
            // 
            // tx_NgaySinh
            // 
            this.tx_NgaySinh.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_NgaySinh.Location = new System.Drawing.Point(440, 191);
            this.tx_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.tx_NgaySinh.Name = "tx_NgaySinh";
            this.tx_NgaySinh.Size = new System.Drawing.Size(329, 27);
            this.tx_NgaySinh.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(62, 416);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(943, 320);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bt_Sua
            // 
            this.bt_Sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Sua.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.Location = new System.Drawing.Point(354, 340);
            this.bt_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(155, 40);
            this.bt_Sua.TabIndex = 10;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.b_Sua_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Xoa.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Location = new System.Drawing.Point(582, 340);
            this.bt_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(155, 40);
            this.bt_Xoa.TabIndex = 11;
            this.bt_Xoa.Text = "Xoá";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.b_Xoa_Click);
            // 
            // tx_NhanVien
            // 
            this.tx_NhanVien.AutoSize = true;
            this.tx_NhanVien.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_NhanVien.Location = new System.Drawing.Point(440, 296);
            this.tx_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.tx_NhanVien.Name = "tx_NhanVien";
            this.tx_NhanVien.Size = new System.Drawing.Size(103, 24);
            this.tx_NhanVien.TabIndex = 12;
            this.tx_NhanVien.TabStop = true;
            this.tx_NhanVien.Text = "Nhân viên";
            this.tx_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tx_QuanLy
            // 
            this.tx_QuanLy.AutoSize = true;
            this.tx_QuanLy.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_QuanLy.Location = new System.Drawing.Point(595, 296);
            this.tx_QuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.tx_QuanLy.Name = "tx_QuanLy";
            this.tx_QuanLy.Size = new System.Drawing.Size(85, 24);
            this.tx_QuanLy.TabIndex = 13;
            this.tx_QuanLy.TabStop = true;
            this.tx_QuanLy.Text = "Quản lý";
            this.tx_QuanLy.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(418, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 27);
            this.label12.TabIndex = 14;
            this.label12.Text = "THÔNG TIN NHÂN SỰ";
            // 
            // bt_Luu
            // 
            this.bt_Luu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Luu.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.Location = new System.Drawing.Point(130, 340);
            this.bt_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(155, 40);
            this.bt_Luu.TabIndex = 9;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.b_Luu_Click);
            // 
            // LamMoi
            // 
            this.LamMoi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LamMoi.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LamMoi.Location = new System.Drawing.Point(804, 340);
            this.LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.LamMoi.Name = "LamMoi";
            this.LamMoi.Size = new System.Drawing.Size(138, 40);
            this.LamMoi.TabIndex = 15;
            this.LamMoi.Text = "Làm mới";
            this.LamMoi.UseVisualStyleBackColor = false;
            this.LamMoi.Click += new System.EventHandler(this.LamMoi_Click);
            // 
            // frm_NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1046, 780);
            this.Controls.Add(this.LamMoi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tx_QuanLy);
            this.Controls.Add(this.tx_NhanVien);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.tx_NgaySinh);
            this.Controls.Add(this.tx_SDT);
            this.Controls.Add(this.tx_TenNS);
            this.Controls.Add(this.txtMaNS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Nhân Sự";
            this.Load += new System.EventHandler(this.frm_NhanSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtMaNS;
        public System.Windows.Forms.TextBox tx_TenNS;
        public System.Windows.Forms.TextBox tx_SDT;
        public System.Windows.Forms.DateTimePicker tx_NgaySinh;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.RadioButton tx_NhanVien;
        private System.Windows.Forms.RadioButton tx_QuanLy;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button LamMoi;
    }

}