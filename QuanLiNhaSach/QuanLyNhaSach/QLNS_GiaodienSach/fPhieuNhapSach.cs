using QLNS_GiaodienSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_GiaodienSach
{
    public partial class fPhieuNhapSach : Form
    {
        public fPhieuNhapSach()
        {
            InitializeComponent();
            LoadPhieuDaNhap();
        }

        private void LoadPhieuDaNhap()
        {
            string query_HienThiDSPhieuNhap = "select MaPhieuNhap 'Mã Phiếu Nhập' , NgayTaoPhieu 'Ngày Tạo Phiếu'" +
                                                "from   PHIEU_NHAP_SACH";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery(query_HienThiDSPhieuNhap);
            dgvPhieuNhap.DataSource = dt;
        }

        private void LoadCT_PNS()
        {
            string query_HienThiCT_PNS = "select * " +
                                   "from   " +
                                   "where";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery(query_HienThiCT_PNS);
            dgvCT_PhieuDaNhap.DataSource = dt;
        }

        private void txbMaSach_TextChanged(object sender, EventArgs e)
        {
            Random rd = new Random();
            txbMaSach.Text = ("SA0" + rd.Next(99, 1000));
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select TenTL from THE_LOAI";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cbbTheLoai.DataSource = data;
            cbbTheLoai.DisplayMember = "TenTL";
        }

       
        ///
        private void lbThemTheLoai_Click(object sender, EventArgs e)
        {
            fTheLoai f = new fTheLoai();
            f.ShowDialog();
            this.Show();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ///
        
        
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            
            /*
            if (txbSach.Text == "" || txbTacGia.Text == "" || cbbTheLoai.Text == "" || dUDSoLuong.Text == "" || txbDonGiaNhap.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else

            {*/


                /*
                DateTime namxb =dtpNgayNhap.Value;

                string query = "Insert into SACH values('" + txbMaSach.Text + "','" + txbSach.Text + "'," +
                        "(Select MATG From TACGIA Where TENTG = '" + cboTenTacGia.Text.ToString() + "'),'" + cboTenLinhVuc.Text + "','" + cboTenLoaiSach.Text + "','" + numericUpDownGiaMua.Value + "'," +
                        "'" + numericUpDownGiaBia.Value + "','" + numericUpDownLanTaiBan.Value + "','" + cboTenNXB.Text.ToString() + "'," +
                        "'" + namxb.ToString("yyyy-MM-dd") + "')";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                txbMaSach_TextChanged();
                txbTenSach.Text = "";
                cbMaTacGia_SelectedIndexChanged();
                cbTenLinhVuc_SelectedIndexChanged();
                cbTenLoaiSach_SelectedIndexChanged();
                cbTenNXB_SelectedIndexChanged();
                numericUpDownGiaMua.Value = 1000;
                numericUpDownGiaBia.Value = 1000;
                numericUpDownLanTaiBan.Value = 0;
                dateTimePickerNamXuatBan.Text = DateTime.Now.ToString();*/
            }
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {

        }

        private void cbbTheLoai1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
}

