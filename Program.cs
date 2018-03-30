using System;
using System.Data.SqlClient;
namespace Ado.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().GetData();
        }
        public void GetData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=CG-DTE-Student;Initial Catalog=BhupyJ;Integrated Security=True");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table student1(id int not null,name varchar(100), email varchar(50), join_date date)", con);
                // Opening Connection
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
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
     

