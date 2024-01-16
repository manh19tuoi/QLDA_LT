using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QQ
{
    public class db
    {
        string strCon = @"Data Source=DESKTOP-DJEJ0LO\BESAU;Initial Catalog=XDPMQL_LT;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
        SqlConnection conn = null;

        public db()
        {
            try
            {
                conn = new SqlConnection(strCon);

            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed: " + ex.Message);
            }
        }



    }
}
