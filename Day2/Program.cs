using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2___Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Course course1 = new Course();
            course1.CourseID = 1;
            course1.CourseName = " C#";
            course1.Instructor = "ED";

            Course course2 = new Course();
            course2.CourseID = 2;
            course2.CourseName = " Java";
            course2.Instructor = "Unknown";

            Console.WriteLine(course1.CourseName);

            Course[] courseArray = new Course[] {course1, course2 };

            foreach (Course course in courseArray) 
            {
                Console.WriteLine(course.CourseName + " : " + course.Instructor);
            }

            Console.Read();
        }

        class Course
        {
            public int CourseID { get; set; }
            public string CourseName { get; set; }
            public string Instructor { get; set; }

        }
    }
}
