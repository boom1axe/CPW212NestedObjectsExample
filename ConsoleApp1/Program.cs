using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInst = new Instructor()
            {
                FullName = "Homer Simpson",
                Email = "Homer.Simpson@email.com"
            };

            Student s1 = new Student()
            {
                firstName = "jim",
                LastName = "Halpert",
                Schedule = new List<Course>()
            };

            Student s2 = new Student()
            {
                firstName = "Creed",
                LastName = "Bratton"
            };

            Student s3 = new Student()
            {
                firstName = "Kelly",
                LastName = "Kapur"
            };

            Course c1 = new Course()
            {
                Title = "CPW 212 - Adv .NET",
                Description = "More .Net than " +
                "what you already learned",
                Credits = 5,
                CourseInstructor = currInst,
                Roster = new List<Student>()
            };

            Course c2 = new Course()
            {
                Title = "CPW 212 - Adv .NET",
                Description = "More .Net than " +
                "what you already learned",
                Credits = 5,
                CourseInstructor = currInst,
                Roster = new List<Student>()
            };

            Course c3 = new Course()
            {
                Title = "CPW 212 - Adv .NET",
                Description = "More .Net than " +
                "what you already learned",
                Credits = 5,
                CourseInstructor = currInst,
                Roster = new List<Student>()
            };

            //student one schdule
            s1.Schedule.Add(c1);
            s1.Schedule.Add(c2);
            s1.Schedule.Add(c3);

            // course one roster
            c1.Roster.Add(s1);
            c1.Roster.Add(s2);
            c1.Roster.Add(s3);

            Console.WriteLine(c1.Title);
            Console.WriteLine("Is Taught by "
                + c1.CourseInstructor.FullName);

            Console.WriteLine("Currently Enrolled Students: ");
            foreach (Student s in c1.Roster)
            {
                Console.WriteLine($"{s.firstName} {s.LastName}");
                Console.WriteLine();
            }
            Console.WriteLine($"Current Schedule of {s1.firstName}:");
            foreach (Course c in s1.Schedule)
            {
                Console.WriteLine($"{c.Title}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
