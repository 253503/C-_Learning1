using System.Data.SqlClient;

namespace DbConnectionDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            SqlConnection con = new
                SqlConnection("Data Source=8516181D2C415F4;Initial Catalog=master;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("select * from tblEmployee", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr["id"] + " | " + rdr["EmployeeName"]);
            }
        }
    }
}