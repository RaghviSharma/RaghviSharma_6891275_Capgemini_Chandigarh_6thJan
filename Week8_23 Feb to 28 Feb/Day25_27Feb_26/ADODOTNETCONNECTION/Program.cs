using System;
using System.Data;
using Microsoft.Data.SqlClient;
namespace ADODOTNETCONNECTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Data Source=RAGHVISHARMA\\SQLEXPRESS;Initial Catalog=UniversityDB;" + "TrustServerCertificate=True;Integrated Security=True;";
                GetStudents(connectionString);
                InsertStudent(connectionString,"Rishi", "Sharma", "rishu2611@gmail.com", 1);
                UpdateStWithId(connectionString, 2, "Aryan", "Chaudhary", "aryan2629@gmail.com", 1);
				
			}
            catch(Exception ex)
            {
                Console.WriteLine("Error.." + ex.Message);
            }
        }
        static void GetStudents(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetStudents", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"First Name: {reader["FirstName"]}, " +
                                      $"LastName: {reader["LastName"]}, " +
                                      $"Email: {reader["Email"]}, " +
                                      $"DeptId:{reader["DeptId"]}");
                }
                reader.Close();
                connection.Close();

            }
        }
        static void InsertStudent(string connectionString, string FirstName, string LastName, string email, int deptId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("InsertStudent", connection);
               
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DeptId", deptId);
				connection.Open();
				command.ExecuteNonQuery();
               
                Console.WriteLine("Inserted details succesfully");
				connection.Close();

			}
        }
        static void UpdateStWithId(string connectionString,int StudentId, string FirstName, string LastName, string email, int deptId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UpdateStWithId", connection);
                command.CommandType= CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentId", StudentId);
				command.Parameters.AddWithValue("@FirstName", FirstName);
				command.Parameters.AddWithValue("@LastName", LastName);
				command.Parameters.AddWithValue("@Email", email);
				command.Parameters.AddWithValue("@DeptId", deptId);
				connection.Open();
				command.ExecuteNonQuery();

				Console.WriteLine("Updated details succesfully");
				connection.Close();

			}
        }
    }
}
