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
    public partial class fManHinhChinh : Form
    {
        public fManHinhChinh()
        {
            InitializeComponent();
        }
        private void fManHinhChinh_Load(object sender, EventArgs e)
        {

        }


        private void ThemNguoiDungMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemTaiKhoan f = new fThemTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ThongTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaiKhoan f = new fTaiKhoan();
            this.Hide();
            f.ShowDialog();//Xu ly xong Showdialog mới tới các hiển thị khác
            this.Show();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản hiện tại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
                    
        // SÁCH
        private void NhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhieuNhapSach f=new fPhieuNhapSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ChinhSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDuLieuSach f = new fDuLieuSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        //THỂ LOẠI
        private void TheLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTheLoai f=new fTheLoai();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        //LẬP PHIẾU
        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHoaDon f = new fHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PhieuThuTienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhieuThuTien f=new fPhieuThuTien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        // KHÁCH HÀNG
        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhachHang f=new fKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        // BÁO CÁO
        private void BCaoCongNo_LapMoi_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapBaoCaoCongNo f = new fNhapBaoCaoCongNo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BCaoCongNo_XemLai_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemBaoCaoCongNo f = new fXemBaoCaoCongNo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BCaoTon_LapMoi_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapBaoCaoTon f = new fNhapBaoCaoTon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BCaoTon_XemLai_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemBaoCaoTon f = new fXemBaoCaoTon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        // THAY ĐỔI QUY ĐỊNH
        private void ThayDoiQuyDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThayDoiQuyDinh f = new fThayDoiQuyDinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

    }
}
