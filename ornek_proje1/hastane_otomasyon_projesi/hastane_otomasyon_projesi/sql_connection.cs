using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_otomasyon_projesi
{
    internal class sql_connection
    {
        public SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9HIBIC6I\\SQLEXPRESS;Initial Catalog=hastane_otomasyon;Integrated Security=True");
            conn.Open();
            return conn;
        }

    }
}
