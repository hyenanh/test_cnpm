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
    public partial class fTheLoai : Form
    {

        /*public class DataProvider
        {
            private string conStr = "Data Source=DESKTOP-VEK6H5B;Database=QUAN_LI_NHA_SACH;Integrated Security=SSPI";

            public DataTable ExcuteQuery(string query)
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);

                    connection.Close();
                }

                return data;
            }
        }*/

        public fTheLoai()
        {
            InitializeComponent();
            LoadTheLoaiList();
        }

        DataTable dt = new DataTable();
        void LoadTheLoaiList()
        {
            string queryShowList = "SELECT MATL 'Mã Thể loại', TenTL 'Thể Loại' " +
                                         "from   THE_LOAI";
            dt = DataProvider.Instance.ExcuteQuery(queryShowList);
            dGvTheLoai.DataSource = dt;
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thể loại mới!");
            }
            else
            {
                string query_Add = "INSERT INTO THE_LOAI (TenTL)" +
                                " VALUES (N'" + tbTheLoai.Text + "')";
                int add = DataProvider.Instance.ExcuteNonQuery(query_Add);
                if (add > 0)
                {
                    LoadTheLoaiList();
                    MessageBox.Show("Cập nhật thành công");
                    tbTheLoai.Clear();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            } 
                
            
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
