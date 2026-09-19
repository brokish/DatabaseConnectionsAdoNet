using Microsoft.Data.SqlClient;
using System.Data;

string connectionString = "Server=.\\SQLEXPRESS; Database=UniversityDb; Trusted_Connection=True; TrustServerCertificate=True";
using SqlConnection connection = new SqlConnection(connectionString); 
connection.Open(); 

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("Connected");


string sql = @"CREATE TABLE Students2
(
    Id INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Age INT,
    Email NVARCHAR(100)
);";
using SqlCommand command = new SqlCommand(sql, connection);
int rows=command.ExecuteNonQuery();
Console.WriteLine($"Table created successfully.  {rows}");
connection.Close();



    /*string sql = "SELECT Id, FirstName, LastName, Age, Email FROM Students";

    using SqlCommand command = new SqlCommand(sql, connection);
    using SqlDataReader reader = command.ExecuteReader();


    while (reader.Read())
    {
        int? id = Convert.ToInt32(reader["Id"]);
        string? firstName = reader["FirstName"].ToString();
        string? lastName = reader["LastName"].ToString();
        int? age = Convert.ToInt32(reader["Age"]);
        string? email = reader["Email"].ToString();

        Console.WriteLine($"ID: {id} | {firstName} {lastName} | ასაკი: {age} | Email: {email}");
    }*/



    /*
    Console.Write("სახელი");
    string firstName = Console.ReadLine();

    Console.Write("შეიყვანეთ გვარი");
    string lastName = Console.ReadLine();

    Console.Write("ასაკი");
    int age = int.Parse(Console.ReadLine());

    Console.Write("Email");
    string email = Console.ReadLine();

    string sql = @"INSERT INTO Students2 (FirstName, LastName, Age, Email)
               VALUES (@FirstName, @LastName, @Age, @Email);";

    using SqlCommand command = new SqlCommand(sql, connection);
    command.Parameters.AddWithValue("@FirstName", firstName);
    command.Parameters.AddWithValue("@LastName", lastName);
    command.Parameters.AddWithValue("@Age", age);
    command.Parameters.AddWithValue("@Email", email);
    */

    /*
    command.ExecuteNonQuery();
    */


    /*Console.Write("შეიყვანეთ  Id");
    int id = int.Parse(Console.ReadLine());

    Console.Write("შეიყვანეთ ახალი ასაკი");
    int newAge = int.Parse(Console.ReadLine());

    Console.Write("შეიყვანეთ ახალი ემეილი");
    string newEmail = Console.ReadLine();

    string sql = @"UPDATE Students2
               SET Age = @Age, Email = @Email
               WHERE Id = @Id;";

    using SqlCommand command = new SqlCommand(sql, connection);
    command.Parameters.AddWithValue("@Age", newAge);
    command.Parameters.AddWithValue("@Email", newEmail);
    command.Parameters.AddWithValue("@Id", id);

    command.ExecuteNonQuery();*/
    
    //წაშლა
    /*Console.Write("წასაშლელი სტუდენტის აიდი");
    int id = int.Parse(Console.ReadLine());

    string sql = @"DELETE FROM Students2
               WHERE Id = @Id;";

    using SqlCommand command = new SqlCommand(sql, connection);
    command.Parameters.AddWithValue("@Id", id);

    command.ExecuteNonQuery();*/