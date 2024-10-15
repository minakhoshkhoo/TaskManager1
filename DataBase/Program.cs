using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.Data.SqlClient;
namespace DataBase
{
    internal class Program
    {
        string connectionString = "Server=50.0.0.31;Database=myDataBase;User Id=minakh;Password=7482;";
        private void Connectuser1ToDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            connection.Close();
            Console.WriteLine("Connection opened successfully");
        }

        private void Connectuser2ToDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            connection.Close();
            Console.WriteLine("Connection opened successfully");
        }

        private void Connectuser3ToDatabase()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            connection.Close();
            Console.WriteLine("Connection opened successfully");
        }

        public void GetUsers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM [user]";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["firstName"]} {reader["lastName"]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void AddUser(string firstName, string lastName, string userName, string password, string tellphone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO [user] (firstName, lastName, userName, [password], tellphone,status,image) " +
                                   "VALUES (firstName, lastName, userName, password, tellphone,status,image)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("firstName", firstName);
                    command.Parameters.AddWithValue("lastName", lastName);
                    command.Parameters.AddWithValue("userName", userName);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("tellphone", tellphone);
                    //command.Parameters.AddWithValue("status", status);
                    //command.Parameters.AddWithValue("image", image);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
