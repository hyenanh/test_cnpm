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
    public partial class fTaiKhoan : Form
    {
        private string TenDN;

        public fTaiKhoan(string TenDN)
        {
            InitializeComponent();
            this.TenDN = TenDN;
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            //Truyền dữ liệu vào
            DataTable dt = new DataTable();
            string queryTimKiemTaiKhoan = "SELECT * FROM TAI_KHOAN WHERE TenDN='" + TenDN + "'";
            dt=DataProvider.Instance.ExcuteQuery(queryTimKiemTaiKhoan);
            DataRow row=dt.Rows[0];
            txbMaNhanVien.Text = row["MaTK"] + "";
            txbTenNhanVien.Text = row["HoTenNV"] + "";
            txbDiaChi.Text = row["DiaChi"] + "";
            txbSoDienThoai.Text = row["SDT"] + "";
            txbEmail.Text = row["email"] + "";
            txbTenDangNhap.Text = row["TenDN"] + "";
            txbGioiTinh.Text = row["GioiTinh"] + "";
            dtpNgaySinh.Text = row["NgaySinh"] + "";
            //Chuc vu
            string queryTimChucVu = "SELECT TenPhanQuyen FROM TAI_KHOAN, PHANQUYEN" +
                                        " WHERE TAI_KHOAN.MaPhanQuyen=PHANQUYEN.MaPhanQuyen" +
                                        " AND TenDN='" + TenDN + "'";
            txbChucVu.Text = (string) DataProvider.Instance.ExcuteScalar(queryTimChucVu);

        }

       
        

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau form = new fDoiMatKhau(TenDN);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
