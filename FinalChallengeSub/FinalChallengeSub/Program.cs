using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallengeSub
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                //creating and saving a new student
                Console.Write("Enter a name of a student: ");
                var userInput = Console.ReadLine();

                var student = new Student { StudentName = userInput };
                db.Students.Add(student);
                db.SaveChanges();

                //Display all students from database
                var query = from b in db.Students orderby b.StudentName select b;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual List<Student> Students { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
