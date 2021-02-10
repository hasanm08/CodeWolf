using System;
using System.Collections.Generic;

namespace ProgrammingSchool.Classes
{
    class Course
    {
        public string Id { get; set; }
        public string TeacherId { get; set; }
        public string ClassId { get; set; }
        public string Name { get; set; }
        public CourseDate Date { get; set; }
        public List<Student> Students { get; set; }
        public Course(string id, string teacherId, string classId, string name, CourseDate date)
        {
            Id = id;
            TeacherId = teacherId;
            ClassId = classId;
            Name = name;
            Date = date;
            Students = new List<Student>();
            //send to db
        }

        public Teacher GetTeacher()
        {
            throw new NotImplementedException();
        }
        public Class GetClass()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Id == course.Id &&
                   TeacherId == course.TeacherId &&
                   ClassId == course.ClassId &&
                   Name == course.Name &&
                   Date == course.Date;
        }

        public override int GetHashCode()
        {
            int hashCode = -298039879;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TeacherId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClassId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            return hashCode;
        }


        public static bool operator ==(Course left, Course right)
        {
            return EqualityComparer<Course>.Default.Equals(left, right);
        }

        public static bool operator !=(Course left, Course right)
        {
            return !(left == right);
        }
    }
}
