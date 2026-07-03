using ConsoleApp1.Config;
using ConsoleApp1.Repositories;
using Microsoft.Data.SqlClient;

namespace JobPortalConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(DbConfig.ConnectionString);

                connection.Open();

                Console.WriteLine("Database connected successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database connection failed.");
                Console.WriteLine("Error message:");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}  