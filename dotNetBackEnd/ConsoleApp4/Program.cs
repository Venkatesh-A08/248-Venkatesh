using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=NorthWind; integrated security=SSPI");

            SqlCommand cm = new SqlCommand("Select * from Products", con);
            con.Open();
            SqlDataReader sdr = cm.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine(sdr["ProductName"] + "-->" + sdr["UnitPrice"]);
            }
        }
    }
}
