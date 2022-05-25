namespace QLNS_GiaodienSach
{
    partial class fNhapBaoCaoCongNo
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
            this.lbCongNo = new System.Windows.Forms.Label();
            this.lbMaCongNo = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.dtpNam = new System.Windows.Forms.DateTimePicker();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCongNo
            // 
            this.lbCongNo.AutoSize = true;
            this.lbCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCongNo.Location = new System.Drawing.Point(126, 47);
            this.lbCongNo.Name = "lbCongNo";
            this.lbCongNo.Size = new System.Drawing.Size(345, 38);
            this.lbCongNo.TabIndex = 0;
            this.lbCongNo.Text = "Nhập báo cáo công nợ";
            // 
            // lbMaCongNo
            // 
            this.lbMaCongNo.AutoSize = true;
            this.lbMaCongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaCongNo.Location = new System.Drawing.Point(74, 123);
            this.lbMaCongNo.Name = "lbMaCongNo";
            this.lbMaCongNo.Size = new System.Drawing.Size(96, 20);
            this.lbMaCongNo.TabIndex = 1;
            this.lbMaCongNo.Text = "Mã công nợ";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThang.Location = new System.Drawing.Point(74, 163);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(55, 20);
            this.lbThang.TabIndex = 2;
            this.lbThang.Text = "Tháng";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNam.Location = new System.Drawing.Point(74, 204);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(44, 20);
            this.lbNam.TabIndex = 3;
            this.lbNam.Text = "Năm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 4;
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM";
            this.dtpThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(278, 163);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(207, 27);
            this.dtpThang.TabIndex = 5;
            // 
            // dtpNam
            // 
            this.dtpNam.CustomFormat = "yyyy";
            this.dtpNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNam.Location = new System.Drawing.Point(278, 202);
            this.dtpNam.Name = "dtpNam";
            this.dtpNam.Size = new System.Drawing.Size(207, 27);
            this.dtpNam.TabIndex = 6;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.Location = new System.Drawing.Point(482, 267);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(125, 36);
            this.btnTroVe.TabIndex = 17;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChon.Location = new System.Drawing.Point(332, 267);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(125, 36);
            this.btnChon.TabIndex = 16;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // fNhapBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 329);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dtpNam);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbMaCongNo);
            this.Controls.Add(this.lbCongNo);
            this.Name = "fNhapBaoCaoCongNo";
            this.Text = "Nhập báo cáo công nợ";
            this.Load += new System.EventHandler(this.fNhapBaoCaoCongNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCongNo;
        private System.Windows.Forms.Label lbMaCongNo;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.DateTimePicker dtpNam;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnChon;
    }
}