using StudentManagement.Models;
using System.Collections.Generic;

namespace StudentManagement.Services
{
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(string Id);
        Student Create(Student student);
        void Update(string Id, Student student);
        void Delete(string Id);
    }
}
