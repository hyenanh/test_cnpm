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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTheLoai));
            this.dGvTheLoai = new System.Windows.Forms.DataGridView();
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
            this.dGvTheLoai.AllowUserToAddRows = false;
            this.dGvTheLoai.AllowUserToDeleteRows = false;
            this.dGvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGvTheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGvTheLoai.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvTheLoai.Location = new System.Drawing.Point(0, 0);
            this.dGvTheLoai.Name = "dGvTheLoai";
            this.dGvTheLoai.ReadOnly = true;
            this.dGvTheLoai.RowHeadersWidth = 51;
            this.dGvTheLoai.Size = new System.Drawing.Size(308, 204);
            this.dGvTheLoai.TabIndex = 0;
            // 
            // lTheLoai
            // 
            this.lTheLoai.AutoSize = true;
            this.lTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lTheLoai.Location = new System.Drawing.Point(3, 16);
            this.lTheLoai.Name = "lTheLoai";
            this.lTheLoai.Size = new System.Drawing.Size(77, 17);
            this.lTheLoai.TabIndex = 1;
            this.lTheLoai.Text = "Thể Loại:";
            // 
            // tbTheLoai
            // 
            this.tbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTheLoai.Location = new System.Drawing.Point(84, 14);
            this.tbTheLoai.Name = "tbTheLoai";
            this.tbTheLoai.Size = new System.Drawing.Size(230, 23);
            this.tbTheLoai.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lTheLoai);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.tbTheLoai);
            this.panel1.Location = new System.Drawing.Point(8, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 91);
            this.panel1.TabIndex = 7;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.Location = new System.Drawing.Point(220, 43);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(94, 29);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTroVe
            // 
            this.btTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTroVe.Location = new System.Drawing.Point(231, 318);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(94, 29);
            this.btTroVe.TabIndex = 8;
            this.btTroVe.Text = "Trở Về";
            this.btTroVe.UseVisualStyleBackColor = true;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // gBTheLoai
            // 
            this.gBTheLoai.Controls.Add(this.dGvTheLoai);
            this.gBTheLoai.Location = new System.Drawing.Point(17, 11);
            this.gBTheLoai.Name = "gBTheLoai";
            this.gBTheLoai.Size = new System.Drawing.Size(308, 204);
            this.gBTheLoai.TabIndex = 9;
            this.gBTheLoai.TabStop = false;
            // 
            // fTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.gBTheLoai);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "fTheLoai";
            this.Text = "Thể loại";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dGvTheLoai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBTheLoai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGvTheLoai;
        private System.Windows.Forms.Label lTheLoai;
        private System.Windows.Forms.TextBox tbTheLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.GroupBox gBTheLoai;
    }
}