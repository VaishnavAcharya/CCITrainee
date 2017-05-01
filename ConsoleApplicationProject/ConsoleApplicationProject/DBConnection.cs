using System;
using System.Data.SqlClient;

namespace ConsoleApplicationProject
{
    class DBConnection
    {
        static void Main(string[] args)
        {
            string CS = "Data Source=CCI-LPT-15\\MSSQLSERVER2K14E; Database=Northwind; User Id=sa; password=sa123456#";
            
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select CategoryName,[Description] from Categories",con);
               SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetString(0)} : {rdr.GetString(1)}");
                }
                Console.ReadKey();
            }
           
        }
    }
}
