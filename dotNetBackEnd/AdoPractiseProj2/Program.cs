using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AdoPractiseProj2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=NorthWind; integrated security=SSPI");
            SqlCommand cm = new SqlCommand("Select * from Employees", con);
            con.Open();
            SqlDataReader sdr = cm.ExecuteReader();

            while (sdr.Read())
            {
                Console.WriteLine(" | {0,10} | {1,10} |",sdr["FirstName"] ,sdr["City"]);
            }
        }
    }
}
