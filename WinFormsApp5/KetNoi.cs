using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    public class KetNoi
    {
        string conStr = "Data Source=LAPTOP-8NL4P7LM;Initial Catalog=QLSanPham;Integrated Security=True";
        SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(conStr);
        }
       
        public DataSet LayDuLieu(string truyvan)
        {
            
                DataSet ds = new DataSet();
                using (SqlDataAdapter da = new SqlDataAdapter(truyvan, conn))
                {
                    da.Fill(ds);
                }
                return ds;
            
          
        }
        public bool ThucThi(string truyvan)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(truyvan, conn);
                    int r = cmd.ExecuteNonQuery();
                    return r > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

    }
}
