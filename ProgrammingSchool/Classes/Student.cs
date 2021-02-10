using System;
using System.Collections.Generic;

namespace ProgrammingSchool.Classes
{
    class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Course> Courses { get; set; }
        public Student(string id, string firstName, string lastName, string nationalId, DateTime birthday, string password, string phone, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NationalId = nationalId;
            Birthday = birthday;
            Password = password;
            Phone = phone;
            Address = address;
            Courses = new List<Course>();
            //send to db
        }
        public bool AddCourse(Course course)
        {
            Courses.Add(course);
            //send to db
            return true;
        }
        public bool DeleteCourse(Course course)
        {
            Courses.Remove(course);
            //send to db
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Id == student.Id &&
                   FirstName == student.FirstName &&
                   LastName == student.LastName &&
                   NationalId == student.NationalId;
        }

        public override int GetHashCode()
        {
            int hashCode = 1439492534;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NationalId);
            return hashCode;
        }

        public static bool operator ==(Student left, Student right)
        {
            return EqualityComparer<Student>.Default.Equals(left, right);
        }

        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }
    }
}
