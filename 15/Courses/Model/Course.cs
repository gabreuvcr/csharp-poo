using System.Collections.Generic;

namespace Courses.Model
{
    public class Course
    {
        public string Name { get; set; }
        public HashSet<Student> Students { get; set; }

        public Course(string name)
        {
            Name = name;
            Students = new HashSet<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
