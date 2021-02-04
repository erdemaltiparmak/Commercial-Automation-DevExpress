using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialAutomationDevExpress
{
     class DbConnection
    {
        public SqlConnection connect()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TicariOtomasyonDB;Integrated Security=True");
            cn.Open();
            return cn;

        }
    }
}
