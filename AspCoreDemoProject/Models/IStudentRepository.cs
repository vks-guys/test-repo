using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreDemoProject.Models
{
    public interface IStudentRepository
    {
        List<Student> GetStudent();
    }
}
