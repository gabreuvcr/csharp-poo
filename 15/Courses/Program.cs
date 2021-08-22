using System;
using System.Collections.Generic;
using Courses.Model;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course("A"));
            courses.Add(new Course("B"));
            courses.Add(new Course("C"));
        
            foreach (Course course in courses)
            {
                Console.Write($"How many students for course {course.Name}? ");
                int numStudents = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < numStudents; i++)
                {
                    Console.Write($"Student {i + 1}: ");
                    int id = Int32.Parse(Console.ReadLine());
                    course.AddStudent(new Student(id));
                }
            }

            HashSet<Student> allStudents = new HashSet<Student>();

            foreach (Course course in courses)
            {
                allStudents.UnionWith(course.Students);
            }

            Console.WriteLine($"Total students: {allStudents.Count}");
        }
    }
}
