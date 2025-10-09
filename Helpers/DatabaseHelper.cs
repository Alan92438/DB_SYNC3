using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_SYNC3.Helpers
{
    public class DatabaseHelper
    {
        // 查詢資料表（回傳 DataTable）
        public static DataTable GetTable(string sql)
        {
            using (var conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
        /// <summary>
        /// 執行非查詢命令 (INSERT / UPDATE / DELETE)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            using (var conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
