using System;
using System.Data.SqlClient;
namespace AdoNet 
{
    class Record
    {
        static void Main(string[] args)
        {
            new Record().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=CG-DTE-Student;Initial Catalog=BhupyJ;Integrated Security=True");

                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student1 (id, name, email, join_date)values('11', 'Jitu', 'jitu@gmail.com', '1/3/2018')", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}