using entityLesson.model;
using Microsoft.EntityFrameworkCore;
using entityLesson;
using entityLesson.model;

namespace entityLesson;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=UniversityDb; Trusted_Connection=True; TrustServerCertificate=True");
    }
    
    public void addUser() {

        using (var context = new AppDbContext())
        {
            Console.WriteLine("enter name");

            string name = Console.ReadLine();
            
            Console.WriteLine("enter Firstname");

            string firstname = Console.ReadLine();

            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter mail");
            string mail = Console.ReadLine();

            var Students = new Student
            {
                Name = name,
                Firstname = firstname,
                Age = age,
                Mail = mail
            };
            context.Students.Add(Students);
            context.SaveChanges();
        }

    }

    public void deleteUser()
    {
        using (var context = new AppDbContext())
        {
            Console.WriteLine("enter id to delete User");
            int id = int.Parse(Console.ReadLine());
            
            context.Students.RemoveRange(context.Students.Where(x => x.Id == id));
            context.SaveChanges();
        }
    }
    
    public void getAllUser()
    {
        using (var context = new AppDbContext())
        {
            context.Students.OrderByDescending(x => x.Id).ToList().ForEach(x =>
            {
                Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, Firstname: {x.Firstname}, Age: {x.Age}, Mail: {x.Mail}");
            });
        }
    }

    public void searchUser()
    {
        
        Console.WriteLine("enter id to search User");
        int id = int.Parse(Console.ReadLine());
        using (var context = new AppDbContext())
        {
            var student = context.Students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Firstname: {student.Firstname}, Age: {student.Age}, Mail: {student.Mail}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}

