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
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau(string TenDangNhap)
        {
            InitializeComponent();
            txbTenTaiKhoan.Text = TenDangNhap;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txbMatKhauHienTai.PasswordChar = (char)0;
                txbMatKhauMoi.PasswordChar = (char)0;
                txbNhapLaiMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txbMatKhauHienTai.PasswordChar= '●';
                txbMatKhauMoi.PasswordChar = '●';
                txbNhapLaiMatKhau.PasswordChar = '●';
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
            //return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
               /* string queryLayMatKhau = "Select MatKhau from TAI_KHOAN where TenDN='" + txbTenTaiKhoan.Text + "'";
                string MatKhauLayDuoc = (string)DataProvider.Instance.ExcuteScalar(queryLayMatKhau);*/
                string userName=txbTenTaiKhoan.Text;
                string passWord=txbMatKhauHienTai.Text;
                //Trường hợp mk trống
                if (txbMatKhauHienTai.Text == "" || txbMatKhauMoi.Text == "" || txbNhapLaiMatKhau.Text == "")
                {
                    MessageBox.Show("Không được để trống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Kiem tra mk nhap dung voi mk trong database
                else if(Login(userName, passWord)==false)
                {
                    MessageBox.Show("Nhập sai mật khẩu", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txbMatKhauMoi.Text == txbMatKhauHienTai.Text)
                {
                    MessageBox.Show("Mật khẩu mới phải khác mật khẩu hiện tại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txbMatKhauMoi.Text != txbNhapLaiMatKhau.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không khớp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                
                    string queryCapNhatMatKhau="UPDATE TAI_KHOAN " +
                        "SET MatKhau='" + txbMatKhauMoi.Text + "' WHERE TenDN='" + txbTenTaiKhoan.Text + "'";
                    int kq = DataProvider.Instance.ExcuteNonQuery(queryCapNhatMatKhau);
                    
                    if(kq > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*if (d == DialogResult.Yes)
                        {
                            Application.ExitThread();
                        }*/
                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
