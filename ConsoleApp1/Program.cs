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
                LastName = "Halpert"
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

            Course testCourse = new Course();
            testCourse.Title = "CPW 212 - Adv .NET";
            testCourse.Description = "More .Net than " +
                "what you already learned";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInst;
            testCourse.Roster = new List<Student>();

            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine("Is Taught by "
                + testCourse.CourseInstructor.FullName);

            Console.WriteLine("Currently Enrolled Students: ");
            foreach (Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.firstName} {s.LastName}");
            }

            Console.ReadKey();
        }
    }
}
