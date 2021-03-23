using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Course
    {
        /// <summary>
        /// The offical full Course title
        /// Ex: CPW 212 - Advance .net programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The course catalog offical description
        /// of course 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of college Credits awarded
        /// for passing the course
        /// </summary>
        public string Credits { get; set; }

        /// <summary>
        /// The instructor that teaches the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }

        /// <summary>
        /// Students currently enrolled in class
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
