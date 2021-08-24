using System;

namespace Courses.Model
{
    public class Student
    {
        public int Id { get; set; }

        public Student(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is not Student)
            {
                throw new ArgumentException("Argument type is wrong.");
            }

            Student other = obj as Student;
            
            return Id.Equals(other.Id);
        }
    }
}
