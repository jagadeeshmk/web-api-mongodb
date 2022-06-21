using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StudentManagement.Models
{
    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }
        [BsonElement("courses")]
        public string[]? Courses { get; set; }
        [BsonElement("gender")]
        public string Gender { get; set; }
        [BsonElement("age")]
        public int Age { get; set; }
    }
}
