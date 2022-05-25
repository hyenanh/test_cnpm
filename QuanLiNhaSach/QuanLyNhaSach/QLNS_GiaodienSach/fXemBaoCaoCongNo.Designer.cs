namespace QLNS_GiaodienSach
{
    partial class fXemBaoCaoCongNo
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
            this.dtvDanhSachCongNo = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblXemBaoCao = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDanhSachCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvDanhSachCongNo
            // 
            this.dtvDanhSachCongNo.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtvDanhSachCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDanhSachCongNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clKhachHang,
            this.clNoDau,
            this.clPhatSinh,
            this.clNoCuoi});
            this.dtvDanhSachCongNo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtvDanhSachCongNo.Location = new System.Drawing.Point(37, 99);
            this.dtvDanhSachCongNo.Margin = new System.Windows.Forms.Padding(4);
            this.dtvDanhSachCongNo.Name = "dtvDanhSachCongNo";
            this.dtvDanhSachCongNo.RowHeadersWidth = 51;
            this.dtvDanhSachCongNo.Size = new System.Drawing.Size(725, 214);
            this.dtvDanhSachCongNo.TabIndex = 7;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 6;
            this.clSTT.Name = "clSTT";
            this.clSTT.Width = 125;
            // 
            // clKhachHang
            // 
            this.clKhachHang.HeaderText = "Khách hàng";
            this.clKhachHang.MinimumWidth = 6;
            this.clKhachHang.Name = "clKhachHang";
            this.clKhachHang.Width = 125;
            // 
            // clNoDau
            // 
            this.clNoDau.HeaderText = "Nợ đầu";
            this.clNoDau.MinimumWidth = 6;
            this.clNoDau.Name = "clNoDau";
            this.clNoDau.Width = 125;
            // 
            // clPhatSinh
            // 
            this.clPhatSinh.HeaderText = "Phát Sinh";
            this.clPhatSinh.MinimumWidth = 6;
            this.clPhatSinh.Name = "clPhatSinh";
            this.clPhatSinh.Width = 125;
            // 
            // clNoCuoi
            // 
            this.clNoCuoi.HeaderText = "Nợ cuối";
            this.clNoCuoi.MinimumWidth = 6;
            this.clNoCuoi.Name = "clNoCuoi";
            this.clNoCuoi.Width = 125;
            // 
            // lblXemBaoCao
            // 
            this.lblXemBaoCao.AutoSize = true;
            this.lblXemBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lblXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXemBaoCao.ForeColor = System.Drawing.Color.Black;
            this.lblXemBaoCao.ImageKey = "(none)";
            this.lblXemBaoCao.Location = new System.Drawing.Point(160, 23);
            this.lblXemBaoCao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXemBaoCao.Name = "lblXemBaoCao";
            this.lblXemBaoCao.Size = new System.Drawing.Size(445, 39);
            this.lblXemBaoCao.TabIndex = 8;
            this.lblXemBaoCao.Text = "XEM BÁO CÁO CÔNG NỢ";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.Location = new System.Drawing.Point(655, 368);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(107, 36);
            this.btnTroVe.TabIndex = 9;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // fXemBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.dtvDanhSachCongNo);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblXemBaoCao);
            this.Name = "fXemBaoCaoCongNo";
            this.Text = "Xem báo cáo công nợ";
            ((System.ComponentModel.ISupportInitialize)(this.dtvDanhSachCongNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvDanhSachCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoCuoi;
        private System.Windows.Forms.Label lblXemBaoCao;
        private System.Windows.Forms.Button btnTroVe;
    }
}