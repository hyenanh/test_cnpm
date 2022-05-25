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
            string queryHienThiTheLoai = "select * from TheLoai";
            DataTable dt = DataProvider.Instance.ExcuteQuery(queryHienThiTheLoai);
            finished = false;
            cbTheLoai.DataSource = dt;
            cbTheLoai.DisplayMember = "MaTheLoai";
            cbTheLoai.ValueMember = "TheLoai";
            finished = true;
        }
        private void HienThiToanBoSanPham()
        { 
            
            string queryHienThiSanPham = "SELECT * FROM dbo.Sach";
            dt= DataProvider.Instance.ExcuteQuery(queryHienThiSanPham);
            dgvThongTinSach.DataSource = dt;
        }

        private void txbTimKiemTen_TextChanged(object sender, EventArgs e)
        {
            string queryTimKiem = "Select * from Sach where TenSach like N'%" + txbTimKiemTen.Text + "%'";
            dt = DataProvider.Instance.ExcuteQuery(queryTimKiem);
            dgvThongTinSach.DataSource= dt;
        }
        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            string queryTimKiem = "Select * from Sach where TenSach like N'%" + txbTimKiemTen.Text + "%'";
            dt = DataProvider.Instance.ExcuteQuery(queryTimKiem);
            dgvThongTinSach.DataSource = dt;
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedIndex == -1)
                return;
            if (finished == false) return;
            string TenTheLoai = (string)cbbTheLoai.SelectedValue;
            string queryChonTheLoai = "Select * from Sach where TheLoai=N'" + TenTheLoai + "'";
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
            //Hien the loai dang duoc chon
            cbbTheLoaiSua.SelectedValue = row["TheLoai"] + "";

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để sửa");
                return;
            }
            string queryCapNhat = "UPDATE SACH" +
                                " SET TenSach=N'" + txbTenSach.Text + "', TacGia='" + txbTacGia.Text +
                                "', TheLoai= N'" + cbbTheLoaiSua.SelectedValue + "', DonGiaNhap='"
                                + txbDonGiaNhap.Text + "', DonGiaBan='" + txbDonGiaBan.Text 
                                + "' WHERE MaSach='" + txbMaSach.Text +"'";

            int kq = DataProvider.Instance.ExcuteNonQuery(queryCapNhat);

            if (kq > 0)
            {
                HienThiToanBoSanPham();
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để sửa");
                return;
            }
            string queryDelete = "DELETE FROM Sach WHERE MaSach='" + txbMaSach.Text + "'";
            int kq= DataProvider.Instance.ExcuteNonQuery(queryDelete);
            if(kq > 0)
            {
                HienThiToanBoSanPham();
                MessageBox.Show("Đã xóa thành công");
            }
            else
                MessageBox.Show("Xóa thất bại");

        }


    }
}
