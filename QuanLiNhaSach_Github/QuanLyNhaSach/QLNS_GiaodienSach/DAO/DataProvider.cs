using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLNS_GiaodienSach.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connStr = "Data Source=LAPTOP-3PESOL36\\SQLEXPRESS;Database=QUAN_LI_NHA_SACH;Integrated Security=SSPI";
        public static DataProvider Instance {
            get
            {
               if(instance == null) instance = new DataProvider();
               return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;  
            }
        }

        private DataProvider() {}

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command=new SqlCommand(query, conn);

                if(parameter != null)
                {
                    string[] listPara=query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;

                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command=new SqlCommand(query, conn);

                if(parameter != null)
                {
                    string[] listPara=query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;

                        }
                    }
                }
                data=command.ExecuteNonQuery();
                
                conn.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command=new SqlCommand(query, conn);

                if(parameter != null)
                {
                    string[] listPara=query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;

                        }
                    }
                }
                data=command.ExecuteScalar();
                
                conn.Close();
            }
            return data;
        }
    }
}
