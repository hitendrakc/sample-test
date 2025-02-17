using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter product name: ");
            
        string productName = Console.ReadLine();

        string connectionString = "your_connection_string_here.";
            
        string query = "SELECT * FROM Products WHERE Name LIKE '" + productName + "%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
    
                while (reader.Read())
                {
                    
                    Console.WriteLine(reader["Name"]);
                    
                }
            }
       
        }
    }
}
