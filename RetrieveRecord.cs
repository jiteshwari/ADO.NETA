using System;
using System.Data.SqlClient;
namespace AdoNet 
{
    class RetrieveRecord
    {
        static void Main(string[] args)
        {
            new RetrieveRecord().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(" Data Source=CG-DTE-Student;Initial Catalog=BhupyJ;Integrated Security=True");
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from student1", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
                Console.Read();
            }
        }
    }
}