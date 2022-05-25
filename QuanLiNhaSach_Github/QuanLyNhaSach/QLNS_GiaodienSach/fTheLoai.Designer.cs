namespace QLNS_GiaodienSach
{
    partial class fTheLoai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGvTheLoai = new System.Windows.Forms.DataGridView();
            this.clCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTheLoai = new System.Windows.Forms.Label();
            this.tbTheLoai = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThem = new System.Windows.Forms.Button();
            this.btTroVe = new System.Windows.Forms.Button();
            this.gBTheLoai = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGvTheLoai)).BeginInit();
            this.panel1.SuspendLayout();
            this.gBTheLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGvTheLoai
            // 
            this.dGvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGvTheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheck,
            this.MaTL,
            this.TheLoai});
            this.dGvTheLoai.Location = new System.Drawing.Point(0, 0);
            this.dGvTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.dGvTheLoai.Name = "dGvTheLoai";
            this.dGvTheLoai.RowHeadersWidth = 51;
            this.dGvTheLoai.Size = new System.Drawing.Size(424, 179);
            this.dGvTheLoai.TabIndex = 0;
            // 
            // clCheck
            // 
            this.clCheck.HeaderText = "";
            this.clCheck.MinimumWidth = 6;
            this.clCheck.Name = "clCheck";
            this.clCheck.Width = 24;
            // 
            // MaTL
            // 
            this.MaTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTL.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaTL.HeaderText = "Mã Thể Loại";
            this.MaTL.MinimumWidth = 6;
            this.MaTL.Name = "MaTL";
            this.MaTL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MaTL.Width = 111;
            // 
            // TheLoai
            // 
            this.TheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLoai.DefaultCellStyle = dataGridViewCellStyle2;
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Width = 89;
            // 
            // lTheLoai
            // 
            this.lTheLoai.AutoSize = true;
            this.lTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lTheLoai.Location = new System.Drawing.Point(4, 20);
            this.lTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTheLoai.Name = "lTheLoai";
            this.lTheLoai.Size = new System.Drawing.Size(88, 20);
            this.lTheLoai.TabIndex = 1;
            this.lTheLoai.Text = "Thể Loại:";
            // 
            // tbTheLoai
            // 
            this.tbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTheLoai.Location = new System.Drawing.Point(112, 17);
            this.tbTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.tbTheLoai.Name = "tbTheLoai";
            this.tbTheLoai.Size = new System.Drawing.Size(160, 27);
            this.tbTheLoai.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lTheLoai);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.tbTheLoai);
            this.panel1.Location = new System.Drawing.Point(13, 200);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 112);
            this.panel1.TabIndex = 7;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Location = new System.Drawing.Point(147, 62);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(125, 36);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btTroVe
            // 
            this.btTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTroVe.Location = new System.Drawing.Point(312, 262);
            this.btTroVe.Margin = new System.Windows.Forms.Padding(4);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(125, 36);
            this.btTroVe.TabIndex = 8;
            this.btTroVe.Text = "Trở Về";
            this.btTroVe.UseVisualStyleBackColor = true;
            // 
            // gBTheLoai
            // 
            this.gBTheLoai.Controls.Add(this.dGvTheLoai);
            this.gBTheLoai.Location = new System.Drawing.Point(13, 13);
            this.gBTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.gBTheLoai.Name = "gBTheLoai";
            this.gBTheLoai.Padding = new System.Windows.Forms.Padding(4);
            this.gBTheLoai.Size = new System.Drawing.Size(424, 179);
            this.gBTheLoai.TabIndex = 9;
            this.gBTheLoai.TabStop = false;
            // 
            // fTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.gBTheLoai);
            this.Name = "fTheLoai";
            this.Text = "Thể loại";
            ((System.ComponentModel.ISupportInitialize)(this.dGvTheLoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBTheLoai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGvTheLoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.Label lTheLoai;
        private System.Windows.Forms.TextBox tbTheLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.GroupBox gBTheLoai;
    }
}