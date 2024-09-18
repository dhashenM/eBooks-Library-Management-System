using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Models
{
    public class UserDetailsService
    {
        string constr = "Data Source=.;Initial Catalog=etickets-webapp-db-5;Integrated Security=True;Pooling=False";
        public DataTable GetUserDetails()
        {
            var dt = new DataTable();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("SPGetUserDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            return dt;
        }
    }
}
