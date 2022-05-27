
namespace QLNS_GiaodienSach
{
    partial class fThemSach
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
            this.dgvDsSach = new System.Windows.Forms.DataGridView();
            this.gbDsSach = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbTacGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dUDSoLuong = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbMaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbThemSachMoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSach = new System.Windows.Forms.ComboBox();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.lbThemTheLoai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSach)).BeginInit();
            this.gbDsSach.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDsSach
            // 
            this.dgvDsSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDsSach.Name = "dgvDsSach";
            this.dgvDsSach.Size = new System.Drawing.Size(847, 226);
            this.dgvDsSach.TabIndex = 0;
            // 
            // gbDsSach
            // 
            this.gbDsSach.Controls.Add(this.dgvDsSach);
            this.gbDsSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDsSach.Location = new System.Drawing.Point(0, 0);
            this.gbDsSach.Name = "gbDsSach";
            this.gbDsSach.Size = new System.Drawing.Size(847, 226);
            this.gbDsSach.TabIndex = 1;
            this.gbDsSach.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txbTacGia);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(270, 323);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 31);
            this.panel4.TabIndex = 16;
            // 
            // txbTacGia
            // 
            this.txbTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbTacGia.Location = new System.Drawing.Point(175, 3);
            this.txbTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txbTacGia.Name = "txbTacGia";
            this.txbTacGia.Size = new System.Drawing.Size(186, 22);
            this.txbTacGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(40, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tác Giả";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lbThemTheLoai);
            this.panel3.Controls.Add(this.cbbTheLoai);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(-2, 284);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 70);
            this.panel3.TabIndex = 17;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTheLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(93, 3);
            this.cbbTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(132, 24);
            this.cbbTheLoai.Sorted = true;
            this.cbbTheLoai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thể Loại";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.dUDSoLuong);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(148, 419);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 31);
            this.panel5.TabIndex = 19;
            // 
            // dUDSoLuong
            // 
            this.dUDSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dUDSoLuong.Location = new System.Drawing.Point(93, 3);
            this.dUDSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dUDSoLuong.Name = "dUDSoLuong";
            this.dUDSoLuong.Size = new System.Drawing.Size(94, 22);
            this.dUDSoLuong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.txbMaSach);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel7.ForeColor = System.Drawing.Color.Transparent;
            this.panel7.Location = new System.Drawing.Point(0, 245);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(251, 31);
            this.panel7.TabIndex = 20;
            // 
            // txbMaSach
            // 
            this.txbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbMaSach.Location = new System.Drawing.Point(93, 4);
            this.txbMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.ReadOnly = true;
            this.txbMaSach.Size = new System.Drawing.Size(132, 22);
            this.txbMaSach.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Sách";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbThemSachMoi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbSach);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(267, 245);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 70);
            this.panel2.TabIndex = 21;
            // 
            // lbThemSachMoi
            // 
            this.lbThemSachMoi.AutoSize = true;
            this.lbThemSachMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbThemSachMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbThemSachMoi.ForeColor = System.Drawing.Color.Black;
            this.lbThemSachMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbThemSachMoi.Location = new System.Drawing.Point(17, 39);
            this.lbThemSachMoi.Name = "lbThemSachMoi";
            this.lbThemSachMoi.Size = new System.Drawing.Size(125, 16);
            this.lbThemSachMoi.TabIndex = 3;
            this.lbThemSachMoi.Text = "(Thêm Sách mới)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sách";
            // 
            // cbbSach
            // 
            this.cbbSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbbSach.FormattingEnabled = true;
            this.cbbSach.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbSach.Location = new System.Drawing.Point(175, 15);
            this.cbbSach.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSach.Name = "cbbSach";
            this.cbbSach.Size = new System.Drawing.Size(353, 24);
            this.cbbSach.TabIndex = 2;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnThemSach.ForeColor = System.Drawing.Color.Black;
            this.btnThemSach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThemSach.Location = new System.Drawing.Point(688, 321);
            this.btnThemSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(107, 30);
            this.btnThemSach.TabIndex = 14;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnTroVe.ForeColor = System.Drawing.Color.Black;
            this.btnTroVe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTroVe.Location = new System.Drawing.Point(707, 496);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(107, 30);
            this.btnTroVe.TabIndex = 15;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // lbThemTheLoai
            // 
            this.lbThemTheLoai.AutoSize = true;
            this.lbThemTheLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbThemTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbThemTheLoai.ForeColor = System.Drawing.Color.Black;
            this.lbThemTheLoai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbThemTheLoai.Location = new System.Drawing.Point(11, 45);
            this.lbThemTheLoai.Name = "lbThemTheLoai";
            this.lbThemTheLoai.Size = new System.Drawing.Size(151, 16);
            this.lbThemTheLoai.TabIndex = 3;
            this.lbThemTheLoai.Text = "(Thêm Thể Loại Mới)";
            // 
            // fThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 552);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.gbDsSach);
            this.Name = "fThemSach";
            this.Text = "Thêm Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsSach)).EndInit();
            this.gbDsSach.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsSach;
        private System.Windows.Forms.GroupBox gbDsSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbTacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbThemTheLoai;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DomainUpDown dUDSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbMaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbThemSachMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnTroVe;
    }
}