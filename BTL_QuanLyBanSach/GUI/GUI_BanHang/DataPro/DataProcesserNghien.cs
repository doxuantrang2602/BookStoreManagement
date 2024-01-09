using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DataProcess
{
    internal class DataProcesserNghien
    {
        string strConnect = "Data Source=DESKTOP-SVVHT2F\\SQLEXPRESS;Initial Catalog=BookStoreManagement;Integrated Security=True";
        SqlConnection sqlConnection = null;
        void OpenConnection()
        {
            sqlConnection = new SqlConnection(strConnect);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        void CloseConnection()
        {
            sqlConnection = new SqlConnection(strConnect);
            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }
        public DataTable DataRead(string sqlSelect)
        {
            DataTable dataTable = new DataTable();
            OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, strConnect);
            adapter.Fill(dataTable);
            CloseConnection();
            return dataTable;
        }
        public void ChangeData(string strSql)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
