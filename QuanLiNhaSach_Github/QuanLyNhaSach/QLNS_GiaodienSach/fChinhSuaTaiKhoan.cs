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
    public partial class fChinhSuaTaiKhoan : Form
    {
        public fChinhSuaTaiKhoan()
        {
            InitializeComponent();
            
        }
        bool finished = false;
        private void fChinhSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiChucVu(cbbChucVu);
            HienThiToanBoTaiKhoan();
        }
        DataTable dt=new DataTable();

        private void HienThiChucVu(ComboBox cbbChucVu)
        {
            string queryHienThiChucVu = "select * from PHANQUYEN";
            DataTable dt = DataProvider.Instance.ExcuteQuery(queryHienThiChucVu);
            finished = false;
            cbbChucVu.DataSource = dt;
            cbbChucVu.DisplayMember = "TenPhanQuyen";
            cbbChucVu.ValueMember = "TenPhanQuyen";
            finished = true;
        }
        private void HienThiToanBoTaiKhoan()
        {

            string queryHienThiTaiKhoan = "SELECT MaTK, TenDN, HoTenNV, GioiTinh, NgaySinh, DiaChi, SDT, Email, TenPhanQuyen" +
                                            " FROM PHANQUYEN, TAI_KHOAN"  +
                                            " WHERE TAI_KHOAN.MaPhanQuyen=PHANQUYEN.MaPhanQuyen";
            dt = DataProvider.Instance.ExcuteQuery(queryHienThiTaiKhoan);
            dgvThongTinTaiKhoan.DataSource = dt;
        }

        private void txbTimKiemTen_TextChanged(object sender, EventArgs e)
        {
            string queryTimKiem = "SELECT MaTK, TenDN, HoTenNV, GioiTinh, NgaySinh, DiaChi, SDT, Email, TenPhanQuyen" +
                                  " FROM PHANQUYEN, TAI_KHOAN" +
                " WHERE TAI_KHOAN.MaPhanQuyen=PHANQUYEN.MaPhanQuyen AND" +
                " HoTenNV like N'%" + txbTimKiemTen.Text + "%'";
            dt = DataProvider.Instance.ExcuteQuery(queryTimKiem);
            dgvThongTinTaiKhoan.DataSource = dt;
        }

        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            string queryTimKiem = "SELECT MaTK, TenDN, HoTenNV, GioiTinh, NgaySinh, DiaChi, SDT, Email, TenPhanQuyen" +
                                  " FROM PHANQUYEN, TAI_KHOAN" +
                " WHERE TAI_KHOAN.MaPhanQuyen=PHANQUYEN.MaPhanQuyen AND" +
                " HoTenNV like N'%" + txbTimKiemTen.Text + "%'";
            dt = DataProvider.Instance.ExcuteQuery(queryTimKiem);
            dgvThongTinTaiKhoan.DataSource = dt;
        }

        private void cbbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChucVu.SelectedIndex == -1)
                return;
            if (finished == false) return;
            string TenPhanQuyen = (string)cbbChucVu.SelectedValue;
            string queryChonChucVu = "SELECT MaTK, TenDN, HoTenNV, GioiTinh, NgaySinh, DiaChi, SDT, Email, TenPhanQuyen" +
                                  " FROM PHANQUYEN, TAI_KHOAN" +
                                  " WHERE TAI_KHOAN.MaPhanQuyen=PHANQUYEN.MaPhanQuyen AND" +
                                  " TenPhanQuyen=N'" + TenPhanQuyen + "'";
            dt = DataProvider.Instance.ExcuteQuery(queryChonChucVu);
            dgvThongTinTaiKhoan.DataSource = dt;
        }
        int vt = -1;

        private void dgvThongTinTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = dt.Rows[vt];

            txbMaTK.Text = row["MaTK"] + "";
            txbTenDangNhap.Text = row["TenDN"] + "";
            txbHoTen.Text = row["HoTenNV"] + "";
            txbSoDienThoai.Text = row["SDT"] + "";
            txbDiaChi.Text = row["DiaChi"] + "";
            txbEmail.Text = row["Email"] + "";
            //Hien thi ChucVu 
            HienThiChucVu(cbbChuaVuSua);
            cbbChuaVuSua.SelectedValue = row["TenPhanQuyen"] + "";
            //Hien thi Gioi Tinh
            string queryHienThiGioiTinh = "select DISTINCT GioiTinh from TAI_KHOAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(queryHienThiGioiTinh);
            cbbGioiTinh.DataSource = data;
            cbbGioiTinh.DisplayMember = "GioiTinh";
            cbbGioiTinh.ValueMember = "GioiTinh";
            cbbGioiTinh.SelectedValue = row["GioiTinh"] + "";
            //Hien thi Thoi Gian
            dtpNgaySinh.Text = row["NgaySinh"].ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {

                if (vt == -1)
                {
                    MessageBox.Show("Bạn chưa chọn dòng nào để sửa");
                    return;
                }
                DateTime NgaySinh=dtpNgaySinh.Value;
                string queryCapNhatTaiKhoan = "UPDATE TAI_KHOAN" +
                                    " SET HoTenNV=N'" + txbHoTen.Text 
                                    + "', SDT=" + txbSoDienThoai.Text 
                                    + ", DiaChi=N'" + txbDiaChi.Text 
                                    + "', Email='" + txbEmail.Text 
                                    + "', MaPhanQuyen= (SELECT MaPhanQuyen FROM PHANQUYEN WHERE TenPhanQuyen=N'"+cbbChuaVuSua.SelectedValue+"')"
                                    + ", GioiTinh=N'" + cbbGioiTinh.Text 
                                    + "', NgaySinh='"+NgaySinh.ToString("yyyy-MM-dd")
                                    +"' FROM TAI_KHOAN"
                                    + " WHERE MaTK='" + txbMaTK.Text + "'";
           
                int kqCapNhatTaiKhoan = DataProvider.Instance.ExcuteNonQuery(queryCapNhatTaiKhoan);

                if (kqCapNhatTaiKhoan > 0)
                {
                    HienThiToanBoTaiKhoan();
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lbTenDN_Click(object sender, EventArgs e)
        {

        }
    }
}
