using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        /// <summary>
        /// legal first name
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Legal last
        /// </summary>
        public string LastName { get; set; }

        public List<Course> Schedule { get; set; }
    }
}
