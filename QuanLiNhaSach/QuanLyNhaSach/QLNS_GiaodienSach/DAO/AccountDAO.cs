using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_GiaodienSach.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO();
                return instance; }
            private set { instance = value; }
        }
        
        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "Select * from dbo.Account where UserName= N'"+ userName+ "' AND PassWord =N'" + passWord +"' ";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
