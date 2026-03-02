using System;
using System.Data;
using Microsoft.Data.SqlClient;
namespace ADODOTNETCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Data Source=RAGHVISHARMA\\SQLEXPRESS;Initial Catalog=EMPLOYEEDB;" + "TrustServerCertificate=True;Integrated Security=True;";
                GetAllEmployees(connectionString);
                int EmployeeId = 1;
                GetEmployeeById(connectionString, EmployeeId);
                string firstname = "Raghvi";
                string lastname = "Sharma";
                string email = "raghvi29sharma@gmail.com";
                string street = "ABC";
                string city = "Una";
                string state = "Himachal";
                string postalcode = "174303";
                CreateEmployeeWithAddress(connectionString, firstname, lastname, email, street, city, state, postalcode);
                int employeeId = 4;
				string firstName = "Rishi";
				string lastName = "Sharma";
				string Email = "rishi26sharma@gmail.com";
				string Street = "tapon";
				string City = "mno";
				string State = "Himachal pradesh";
				string Postalcode = "172406";
                int addressId = 4;
                UpdateEmployeeWithAddress(connectionString,employeeId, firstName, lastName, Email, Street, City, State, Postalcode, addressId);
                employeeId = 4;
                DeleteEmployee(connectionString, employeeId);




			}
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong " + ex.Message);
            }
            static void GetAllEmployees(string connectionString)
            {
                Console.WriteLine("GetAllEmployees Stored Procedure Called");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("GetAllEmployees", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"EmployeeId:{reader["EmployeeId"]}," +
                                          $"FirstName:{reader["FirstName"]}," +
                                          $"LastName:{reader["LastName"]}," +
                                          $"email:{reader["email"]},");
                        Console.WriteLine($"Address:{reader["Street"]}," + $"{reader["City"]}," + $"{reader["State"]},PostalCode:" +
                            $"{reader["PostalCode"]},");
                    }
                    reader.Close();
                    connection.Close();
                }
            }

            static void GetEmployeeById(string connectionString, int employeeID)
            {
                Console.WriteLine("GetEmployeeById Stored Procedure Called");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("GetEmployeeById", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeId", employeeID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"EmployeeId:{reader["EmployeeId"]}," +
                                          $"FirstName:{reader["FirstName"]}," +
                                          $"LastName:{reader["LastName"]}," +
                                          $"email:{reader["email"]},");
                        Console.WriteLine($"Address:{reader["Street"]}," + $"{reader["City"]}," + $"{reader["State"]},PostalCode:" +
                            $"{reader["PostalCode"]},");
                    }
                    reader.Close();
                    connection.Close();
                }
            }

            static void CreateEmployeeWithAddress(string connectionString, string firstname, string lastname, string email, string street, string city, string state, string postalcode)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("CreateEmployeeWithAddress", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", firstname);
                    command.Parameters.AddWithValue("@LastName", lastname);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Street", street);
                    command.Parameters.AddWithValue("@City", city);
                    command.Parameters.AddWithValue("@State", state);
                    command.Parameters.AddWithValue("@PostalCode", postalcode);
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee and address created successfully");
                    connection.Close();

                }
            }
				static void UpdateEmployeeWithAddress(string connectionString,int employeeId, string firstname, string lastname, string email, string street, string city, string state, string postalcode,int addressId)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                        command.CommandType= CommandType.StoredProcedure;
						command.Parameters.AddWithValue("@EmployeeID", employeeId);
						command.Parameters.AddWithValue("@FirstName", firstname);
						command.Parameters.AddWithValue("@LastName", lastname);
						command.Parameters.AddWithValue("@Email", email);
						command.Parameters.AddWithValue("@Street", street);
						command.Parameters.AddWithValue("@City", city);
						command.Parameters.AddWithValue("@State", state);
						command.Parameters.AddWithValue("@PostalCode", postalcode);
						command.Parameters.AddWithValue("@AddressId", addressId);
						connection.Open();
						command.ExecuteNonQuery();
						Console.WriteLine("Employee and address updated successfully");
						connection.Close();
					}
                }
                static void DeleteEmployee(string connectionString,int employeeId)
                {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                    command.CommandType= CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    connection.Open();
                    int result= command.ExecuteNonQuery();
                    if(result>0)
                    {
                        Console.WriteLine("Employees and address deleted succesfully");
                    }
                    else
                    {
                        Console.WriteLine("Employees not found");
                    }
                    connection.Close();
                }
                }
        }
    }
}
