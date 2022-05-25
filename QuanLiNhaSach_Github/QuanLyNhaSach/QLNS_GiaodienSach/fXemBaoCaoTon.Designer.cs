namespace QLNS_GiaodienSach
{
    partial class fXemBaoCaoTon
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
            this.dgvDanhSachTon = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.TieuDe = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachTon
            // 
            this.dgvDanhSachTon.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDanhSachTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clSach,
            this.clTonDau,
            this.clPhatSinh,
            this.clTonCuoi});
            this.dgvDanhSachTon.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachTon.Location = new System.Drawing.Point(39, 182);
            this.dgvDanhSachTon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachTon.Name = "dgvDanhSachTon";
            this.dgvDanhSachTon.RowHeadersWidth = 51;
            this.dgvDanhSachTon.Size = new System.Drawing.Size(727, 185);
            this.dgvDanhSachTon.TabIndex = 9;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 6;
            this.clSTT.Name = "clSTT";
            this.clSTT.Width = 125;
            // 
            // clSach
            // 
            this.clSach.HeaderText = "Sách";
            this.clSach.MinimumWidth = 6;
            this.clSach.Name = "clSach";
            this.clSach.Width = 125;
            // 
            // clTonDau
            // 
            this.clTonDau.HeaderText = "Tồn đầu";
            this.clTonDau.MinimumWidth = 6;
            this.clTonDau.Name = "clTonDau";
            this.clTonDau.Width = 125;
            // 
            // clPhatSinh
            // 
            this.clPhatSinh.HeaderText = "Phát Sinh";
            this.clPhatSinh.MinimumWidth = 6;
            this.clPhatSinh.Name = "clPhatSinh";
            this.clPhatSinh.Width = 125;
            // 
            // clTonCuoi
            // 
            this.clTonCuoi.HeaderText = "Tồn cuối";
            this.clTonCuoi.MinimumWidth = 6;
            this.clTonCuoi.Name = "clTonCuoi";
            this.clTonCuoi.Width = 125;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Location = new System.Drawing.Point(517, 106);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(107, 36);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.CustomFormat = "MM/yyyy";
            this.dtpThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(165, 116);
            this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(299, 26);
            this.dtpThoiGian.TabIndex = 7;
            // 
            // TieuDe
            // 
            this.TieuDe.AutoSize = true;
            this.TieuDe.BackColor = System.Drawing.Color.Transparent;
            this.TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieuDe.ForeColor = System.Drawing.Color.Black;
            this.TieuDe.ImageKey = "(none)";
            this.TieuDe.Location = new System.Drawing.Point(269, 33);
            this.TieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Size = new System.Drawing.Size(264, 39);
            this.TieuDe.TabIndex = 6;
            this.TieuDe.Text = "BÁO CÁO TỒN";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.Location = new System.Drawing.Point(659, 410);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(107, 36);
            this.btnTroVe.TabIndex = 10;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // fXemBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 487);
            this.Controls.Add(this.dgvDanhSachTon);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.TieuDe);
            this.Controls.Add(this.btnTroVe);
            this.Name = "fXemBaoCaoTon";
            this.Text = "Xem báo cáo tồn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTonCuoi;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Label TieuDe;
        private System.Windows.Forms.Button btnTroVe;
    }
}