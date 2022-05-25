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
    public partial class fThemTaiKhoan : Form
    {
        public fThemTaiKhoan()
        {
            InitializeComponent();
            HienThiGioiTinh();
            HienThiChucVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime NgaySinh = dtpNgaySinh.Value;
            if(txbTenNhanVien.Text == "" || txbDiaChi.Text=="" || txbSoDienThoai.Text=="" || txbEmail.Text=="" || txbTenDangNhap.Text=="" ||txbMatKhau.Text=="" )
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            Random rd = new Random();
            string queryThemTaiKhoan = "INSERT INTO TAI_KHOAN (HoTenNV, GioiTinh, NgaySinh, DiaCHi, SDT, email, TenDN, MatKhau, MaPhanQuyen, MaTK)" +
                                        " VALUES (N'" + txbTenNhanVien.Text + "', N'"
                                                        + cbbGioiTinh.SelectedValue + "', '"
                                                        + NgaySinh.ToString("yyyy-MM-dd") + "', N'"
                                                        + txbDiaChi.Text + "', '"
                                                        + txbSoDienThoai.Text + "', '"
                                                        + txbEmail.Text + "', '"
                                                        + txbTenDangNhap.Text + "', '"
                                                        + txbMatKhau.Text + "', '"
                                                        + cbbChucVu.SelectedValue + "', 'TK"
                                                        + rd.Next(0, 100) + "')";

            int kq=DataProvider.Instance.ExcuteNonQuery(queryThemTaiKhoan);
            if (kq>0)
            {
                MessageBox.Show("Thêm tài khoản thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txbTenNhanVien.Text = "";
            dtpNgaySinh.Text = DateTime.Now.ToString();
            txbDiaChi.Text = "";
            txbSoDienThoai.Text = "";
            txbEmail.Text = "";
            txbTenDangNhap.Text = "";
            txbMatKhau.Text = "";
        }

        private void HienThiGioiTinh()
        {
            string queryHienThiGioiTinh = "select distinct GioiTinh from TAI_KHOAN";
            DataTable dt = DataProvider.Instance.ExcuteQuery(queryHienThiGioiTinh);
            cbbGioiTinh.DataSource = dt;
            cbbGioiTinh.DisplayMember = "GioiTinh";
            cbbGioiTinh.ValueMember = "GioiTinh";
        }

        private void HienThiChucVu()
        {
            string queryHienThiChucVu = "select * from PHANQUYEN";
            DataTable dt = DataProvider.Instance.ExcuteQuery(queryHienThiChucVu);
            cbbChucVu.DataSource = dt;
            cbbChucVu.DisplayMember = "TenPhanQuyen";
            cbbChucVu.ValueMember = "MaPhanQuyen";
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
