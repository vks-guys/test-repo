using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreDemoProject.Models
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetStudent()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = "Student 1", Age = 25},
                new Student() { Id = 2, Name = "Student 2", Age = 28},
                new Student() { Id = 3, Name = "Student 3", Age = 33},
            };

            return students;
        }
    }
}
