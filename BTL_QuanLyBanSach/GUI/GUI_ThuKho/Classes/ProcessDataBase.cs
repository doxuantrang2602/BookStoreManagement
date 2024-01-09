using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.Classes
{
    internal class ProcessDataBase
    {
        string strConnect = "Data Source=DESKTOP-SVVHT2F\\SQLEXPRESS;Initial Catalog=BookStoreManagement;Integrated Security=True";
        SqlConnection sqlConnect = null;

        //Phương thức mở kết nối
        public void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Phương thức đóng kết nối
        public void CloseConnect()
        {
            if (sqlConnect.State!=ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }

        //Phương thức thực thi câu lệnh Select trả về một DataTable
        public DataTable Select(string sqlSelct)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelct, sqlConnect);
            sqlData.Fill(tblData);
            CloseConnect();
            return tblData;
        }
        //Phương thức thực hiện câu lệnh dạng insert,update,delete
        public void Update(string sql)
        {
            OpenConnect();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConnect;
            sqlcomma.CommandText = sql;
            sqlcomma.ExecuteNonQuery();
            CloseConnect();
        }

        public List<string>GetBookID(string sql)
        {
            List<string> list = new List<string>();
            OpenConnect();

            

            // Tạo đối tượng SqlCommand
            using (SqlCommand command = new SqlCommand(sql, sqlConnect))
            {
                // Thực thi truy vấn và nhận đối tượng SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Kiểm tra xem có dữ liệu hay không
                    if (reader.HasRows)
                    {
                        // Đọc từng dòng dữ liệu
                        while (reader.Read())
                        {
                            // Lấy giá trị từ cột "BookCode"
                            string bookID = reader["BookID"].ToString();

                            // Thêm mã sách vào danh sách
                            list.Add(bookID);
                        }
                    }
                }
            }
        

            // Trả về danh sách mã sách
            return list;
        }

        private T GetValue<T>(SqlDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(columnIndex))
            {
                return (T)reader.GetValue(columnIndex);
            }
            else
            {
                return default(T); // Trả về giá trị mặc định của kiểu nếu cột là NULL
            }
        }

        // Hàm đọc dữ liệu từ CSDL
        public T SqlReader<T>(string sqlQuery, string columnName)
        {
            T valueFromDatabase = default(T);

            OpenConnect();
            using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnect))
            {
                // Thực hiện truy vấn
                SqlDataReader reader = command.ExecuteReader();

                // Kiểm tra xem có dữ liệu không
                if (reader.Read())
                {
                    // Gọi hàm GetValue để lấy giá trị từ cột
                    valueFromDatabase = GetValue<T>(reader, columnName);
                }

                reader.Close();
            }
            

            return valueFromDatabase;
        }

        
    }
}
