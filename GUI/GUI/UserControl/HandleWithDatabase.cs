using System;
using System.Collections.Generic;
using System.Data; // Cần cho DataTable, CommandType
using System.Data.SqlClient;

namespace GUI.UserControl
{
    public class HandleWithDatabase
    {
        private readonly string _connectionString;
        // Constructor: Nhận chuỗi kết nối khi khởi tạo đối tượng
        public HandleWithDatabase(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null or empty.");
            }
            _connectionString = connectionString;
        }
        // --- 1. Lấy thông tin (Read) ---
        /// <summary>
        /// Thực thi câu lệnh SELECT và trả về dữ liệu dưới dạng DataTable.
        /// </summary>
        /// <param name="query">Câu lệnh SQL SELECT (có thể chứa tham số dạng @paramName).</param>
        /// <param name="parameters">Dictionary chứa tên tham số và giá trị tương ứng (tùy chọn).</param>
        /// <returns>DataTable chứa kết quả truy vấn.</returns>
        public DataTable GetData(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Sử dụng 'using' để đảm bảo kết nối và command được giải phóng đúng cách
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào command nếu có
                        if (parameters != null)
                        {
                            AddParameters(command, parameters);
                        }
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    } 
                } 
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL cụ thể (ví dụ: ghi log)
                Console.WriteLine($"SQL Error: {ex.Message}");
                // Có thể throw lại lỗi hoặc trả về DataTable rỗng tùy theo yêu cầu
                // throw;
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác (ví dụ: ghi log)
                Console.WriteLine($"General Error: {ex.Message}");
                // throw;
            }
            return dataTable;
        }

        // --- 2. Thêm, Sửa, Xóa thông tin (Execute Non Query) ---
        /// <summary>
        /// Thực thi các câu lệnh INSERT, UPDATE, DELETE.
        /// </summary>
        /// <param name="query">Câu lệnh SQL INSERT, UPDATE, hoặc DELETE (nên dùng tham số dạng @paramName).</param>
        /// <param name="parameters">Dictionary chứa tên tham số và giá trị tương ứng.</param>
        /// <returns>Số lượng bản ghi bị ảnh hưởng bởi câu lệnh.</returns>
        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            int rowsAffected = 0;
            if (parameters == null || parameters.Count == 0)
            {
                // Cân nhắc: Có cho phép thực thi non-query không có tham số không?
                // Thường thì INSERT/UPDATE/DELETE luôn cần tham số để tránh rủi ro.
                Console.WriteLine("Warning: Executing NonQuery without parameters can be risky.");
                // throw new ArgumentNullException(nameof(parameters), "Parameters are required for ExecuteNonQuery.");
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào command
                        AddParameters(command, parameters);

                        // Mở kết nối
                        connection.Open();

                        // Thực thi câu lệnh và lấy số dòng bị ảnh hưởng
                        rowsAffected = command.ExecuteNonQuery();
                    } // command được Dispose ở đây
                } // connection được Dispose và Close ở đây
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                // throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                // throw;
            }
            return rowsAffected; // Trả về số dòng đã thay đổi
        }


        // --- Hàm tiện ích để thêm tham số ---
        /// <summary>
        /// Thêm các tham số từ Dictionary vào SqlCommand.
        /// </summary>
        private void AddParameters(SqlCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0) return;

            foreach (var param in parameters)
            {
                // Xử lý giá trị null trong C# thành DBNull.Value trong SQL
                object paramValue = param.Value ?? DBNull.Value;
                command.Parameters.AddWithValue(param.Key, paramValue);
            }
        }

        // --- (Tùy chọn) Thực thi và lấy giá trị đơn (Execute Scalar) ---
        /// <summary>
        /// Thực thi câu lệnh SQL và trả về giá trị duy nhất từ cột đầu tiên của dòng đầu tiên trong kết quả.
        /// Hữu ích cho các câu lệnh như COUNT(*), MAX(ID), v.v.
        /// </summary>
        /// <param name="query">Câu lệnh SQL (có thể chứa tham số).</param>
        /// <param name="parameters">Dictionary chứa tham số (tùy chọn).</param>
        /// <returns>Đối tượng chứa giá trị đơn lẻ, hoặc null nếu không có kết quả.</returns>
        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            object result = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            AddParameters(command, parameters);
                        }
                        connection.Open();
                        result = command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
            }
            catch (Exception ex)
            {
            }
            return result;
        }
    }
}
