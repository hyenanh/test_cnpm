using QLNS_GiaodienSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_GiaodienSach
{
    public partial class fDuLieuSach : Form
    {
        public fDuLieuSach()
        {
            InitializeComponent();
        }
        bool finished=false;

        private void fDuLieuSach_Load(object sender, EventArgs e)
        {
            HienThiToanBoSanPham();
            HienThiTheLoai(cbbTheLoai);
        }
        DataTable dt=new DataTable();

        private void HienThiTheLoai(ComboBox cbTheLoai)
        {
            string queryHienThiTheLoai = "select * from THE_LOAI";
            DataTable dt = DataProvider.Instance.ExcuteQuery(queryHienThiTheLoai);
            finished = false;
            cbTheLoai.DataSource = dt;
            cbTheLoai.DisplayMember = "TenTL";
            cbTheLoai.ValueMember = "TenTL";
            finished = true;
        }
        private void HienThiToanBoSanPham()
        { 
            
            string queryHienThiSanPham = "SELECT SACH.MaSach, TenSach, TenTL, TacGia, DonGiaNhap, DonGiaBan, SoLuongTon FROM SACH,  THE_LOAI, CTTL" +
                " where SACH.MaSach=CTTL.MaSach and CTTL.MaTL=THE_LOAI.MaTL";
            dt= DataProvider.Instance.ExcuteQuery(queryHienThiSanPham);
            dgvThongTinSach.DataSource = dt;
        }

        private void txbTimKiemTen_TextChanged(object sender, EventArgs e)
        {
            string queryTimKiem = "Select SACH.MaSach, TenSach, TenTL, TacGia, DonGiaNhap, DonGiaBan, SoLuongTon" +
                " from SACH, THE_LOAI, CTTL" +
                " where SACH.MaSach=CTTL.MaSach and CTTL.MaTL=THE_LOAI.MaTL AND" +
                " TenSach like N'%" + txbTimKiemTen.Text + "%'";
            dt = DataProvider.Instance.ExcuteQuery(queryTimKiem);
            dgvThongTinSach.DataSource= dt;
        }
        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            string queryTimKiem = "Select SACH.MaSach, TenSach, TenTL, TacGia, DonGiaNhap, DonGiaBan, SoLuongTon" +
                " from SACH, THE_LOAI, CTTL" +
                " where SACH.MaSach=CTTL.MaSach and CTTL.MaTL=THE_LOAI.MaTL AND" +
                " TenSach like N'%" + txbTimKiemTen.Text + "%'";
            dt = DataProvider.Instance.ExcuteQuery(queryTimKiem);
            dgvThongTinSach.DataSource = dt;
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedIndex == -1)
                return;
            if (finished == false) return;
            string TenTheLoai = (string)cbbTheLoai.SelectedValue;
            string queryChonTheLoai = "Select SACH.MaSach, TenSach, TenTL, TacGia, DonGiaNhap, DonGiaBan, SoLuongTon" +
               " from SACH, THE_LOAI, CTTL" +
               " where SACH.MaSach=CTTL.MaSach AND CTTL.MaTL=THE_LOAI.MaTL AND" +
               " THE_LOAI.Ten TL=N'" + TenTheLoai + "'";
            dt = DataProvider.Instance.ExcuteQuery(queryChonTheLoai);
            dgvThongTinSach.DataSource=dt;

        }


        int vt = -1;
        private void dgvThongTinSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            
            DataRow row = dt.Rows[vt];

            txbMaSach.Text = row["MaSach"] + "";
            txbTenSach.Text = row["TenSach"] + "";
            txbTacGia.Text = row["TacGia"] + "";
            txbDonGiaNhap.Text = row["DonGiaNhap"] + "";
            txbDonGiaBan.Text = row["DonGiaBan"] + "";
            txbSoLuongTon.Text = row["SoLuongTon"] + "";
            //Hien thi the loai 
            HienThiTheLoai(cbbTheLoaiSua);
            cbbTheLoaiSua.SelectedValue = row["TenTL"]+"";

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để sửa");
                return;
            }
            string queryCapNhatSach = "UPDATE SACH" +
                                " SET TenSach=N'" + txbTenSach.Text + "', TacGia=N'" + txbTacGia.Text  + "', DonGiaNhap='"
                                + txbDonGiaNhap.Text + "', DonGiaBan='" + txbDonGiaBan.Text +
                                "' FROM SACH"
                                + " WHERE SACH.MaSach='" + txbMaSach.Text +"'";
            string queryCapNhatTheLoai = "UPDATE CTTL" +
                                        " SET MATL = (SELECT MATL FROM THE_LOAI WHERE THE_LOAI.TenTL= N'" + cbbTheLoaiSua.SelectedValue +
                                        "') FROM SACH JOIN CTTL ON SACH.MaSach=CTTL.MaSach JOIN THE_LOAI ON CTTL.MaTL=THE_LOAI.MaTL" +
                                        " WHERE SACH.MaSach='" + txbMaSach.Text + "'";
            int kqCapNhatSach = DataProvider.Instance.ExcuteNonQuery(queryCapNhatSach);
            int kqCapNhatTheLoai= DataProvider.Instance.ExcuteNonQuery(queryCapNhatTheLoai);

            if (kqCapNhatSach > 0 && kqCapNhatTheLoai >0)
            {
                HienThiToanBoSanPham();
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThongTinSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
