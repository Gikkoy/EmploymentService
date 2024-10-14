using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmploymentService
{
    internal class Database
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=WIN-GKMEGO7B1S6\SQLEXPRESS; Initial Catalog=DBemployment; Integrated Security=true");

        public void openConnection()
        {
            if(sqlconnection.State==System.Data.ConnectionState.Closed) {
            sqlconnection.Open();
            }
        }
        public void closeConnection()
        {
            if(sqlconnection.State==System.Data.ConnectionState.Open) { 
            sqlconnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlconnection;
        }
    }  
}
