
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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        int count = 1;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbTenDangNhap.Text;
            string passWord = txbMatKhau.Text;
            if (Login(userName, passWord))
            {
                string queryLayMaPhanQuyen = "Select MaPhanQuyen from TAI_KHOAN where TenDN='" + userName + "'";
               
                PhanQuyen.MaPhanQuyen = Int32.Parse((string)DataProvider.Instance.ExcuteScalar(queryLayMaPhanQuyen));
                fManHinhChinh f = new fManHinhChinh(userName);
                this.Hide();
                f.ShowDialog();//Xu ly xong Showdialog mới tới các hiển thị khác
                this.Show();
            }
            else
            {
                count++;
                if (count <= 3)
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "THÔNG BÁO");
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("BẠN đã nhập sai 3 lần liên tiếp, thoát chương trình ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        Application.ExitThread();
                    }
                    count = 1;
                }
            }
            txbTenDangNhap.Text = "";
            txbMatKhau.Text = "";
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
            //return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void lbTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txbMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txbMatKhau.PasswordChar = '●';
            }
        }
    }
}
