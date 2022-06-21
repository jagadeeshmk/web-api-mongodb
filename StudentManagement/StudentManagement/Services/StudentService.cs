using MongoDB.Driver;
using StudentManagement.Models;
using System;
using System.Collections.Generic;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMongoCollection<Student> _students;
        public StudentService(IStudentStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _students = database.GetCollection<Student>(settings.StudentCoursesCollectionName);
        }

        public Student Create(Student student)
        {
            _students.InsertOne(student);
            return student;
        }

        public void Delete(string Id)
        {
            _students.DeleteOne(student => student.Id == Id);
        }

        public List<Student> Get()
        {
            return _students.Find(student => true).ToList();
        }

        public Student Get(string Id)
        {
            return _students.Find(student => student.Id == Id).FirstOrDefault();
        }

        public void Update(string Id, Student student)
        {
            _students.ReplaceOne(student => student.Id == Id, student);
        }
    }
}
