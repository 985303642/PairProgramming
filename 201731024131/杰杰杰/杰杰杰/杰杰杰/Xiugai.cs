using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp
{
    class Xiugai
    {
        public static DataSet CX(string sql)
        {
            DataSet s = new DataSet();
            try
            {
                SqlConnection deng = new SqlConnection("Server=DESKTOP-0SREOAT;database=Demo;Trusted_Connection=true");
                deng.Open();
                SqlDataAdapter q = new SqlDataAdapter(sql, deng);
                q.Fill(s);
                deng.Close();
                return s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return s;
            }

        }
        public static int Caozuo(string sql)
        {
            try
            {
                SqlConnection deng = new SqlConnection("Server=DESKTOP-0SREOAT;database=Demo;Trusted_Connection=true");
                deng.Open();
                SqlCommand command = new SqlCommand(sql, deng);
                int r = command.ExecuteNonQuery();
                deng.Close();
                return r;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }

        }
    }
}
