namespace SYTEM
{
    partial class frm_Luong
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaBL = new System.Windows.Forms.TextBox();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.txtTTT = new System.Windows.Forms.TextBox();
            this.txtTTP = new System.Windows.Forms.TextBox();
            this.txtML = new System.Windows.Forms.TextBox();
            this.txtSGL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayTinhLuong = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Lammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(88, 415);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(875, 311);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(133, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Bảng Lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(133, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân Sự";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(500, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng Tiền Thưởng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(500, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng Tiền Phạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(133, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mức Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(500, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Giờ Làm";
            // 
            // txtMaBL
            // 
            this.txtMaBL.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtMaBL.Location = new System.Drawing.Point(302, 92);
            this.txtMaBL.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBL.Name = "txtMaBL";
            this.txtMaBL.Size = new System.Drawing.Size(135, 27);
            this.txtMaBL.TabIndex = 7;
            // 
            // txtMaNS
            // 
            this.txtMaNS.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtMaNS.Location = new System.Drawing.Point(302, 179);
            this.txtMaNS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(135, 27);
            this.txtMaNS.TabIndex = 8;
            // 
            // txtTTT
            // 
            this.txtTTT.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtTTT.Location = new System.Drawing.Point(699, 143);
            this.txtTTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTTT.Name = "txtTTT";
            this.txtTTT.Size = new System.Drawing.Size(155, 27);
            this.txtTTT.TabIndex = 10;
            // 
            // txtTTP
            // 
            this.txtTTP.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtTTP.Location = new System.Drawing.Point(699, 92);
            this.txtTTP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTTP.Name = "txtTTP";
            this.txtTTP.Size = new System.Drawing.Size(155, 27);
            this.txtTTP.TabIndex = 9;
            // 
            // txtML
            // 
            this.txtML.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtML.Location = new System.Drawing.Point(302, 264);
            this.txtML.Margin = new System.Windows.Forms.Padding(4);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(135, 27);
            this.txtML.TabIndex = 12;
            // 
            // txtSGL
            // 
            this.txtSGL.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtSGL.Location = new System.Drawing.Point(699, 201);
            this.txtSGL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSGL.Name = "txtSGL";
            this.txtSGL.Size = new System.Drawing.Size(155, 27);
            this.txtSGL.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(87, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(328, 339);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(576, 339);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(415, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 27);
            this.label12.TabIndex = 16;
            this.label12.Text = "THÔNG TIN LƯƠNG";
            // 
            // dtpNgayTinhLuong
            // 
            this.dtpNgayTinhLuong.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTinhLuong.Location = new System.Drawing.Point(699, 263);
            this.dtpNgayTinhLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTinhLuong.Name = "dtpNgayTinhLuong";
            this.dtpNgayTinhLuong.Size = new System.Drawing.Size(274, 27);
            this.dtpNgayTinhLuong.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(500, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ngày Tính Lương";
            // 
            // Lammoi
            // 
            this.Lammoi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Lammoi.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lammoi.Location = new System.Drawing.Point(816, 340);
            this.Lammoi.Margin = new System.Windows.Forms.Padding(4);
            this.Lammoi.Name = "Lammoi";
            this.Lammoi.Size = new System.Drawing.Size(138, 44);
            this.Lammoi.TabIndex = 26;
            this.Lammoi.Text = "Làm mới";
            this.Lammoi.UseVisualStyleBackColor = false;
            this.Lammoi.Click += new System.EventHandler(this.Lammoi_Click);
            // 
            // frm_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1046, 780);
            this.Controls.Add(this.Lammoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgayTinhLuong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtML);
            this.Controls.Add(this.txtSGL);
            this.Controls.Add(this.txtTTT);
            this.Controls.Add(this.txtTTP);
            this.Controls.Add(this.txtMaNS);
            this.Controls.Add(this.txtMaBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Luong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lương";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaBL;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.TextBox txtTTT;
        private System.Windows.Forms.TextBox txtTTP;
        private System.Windows.Forms.TextBox txtML;
        private System.Windows.Forms.TextBox txtSGL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker dtpNgayTinhLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Lammoi;
    }
}