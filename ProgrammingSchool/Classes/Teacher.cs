using System;
using System.Collections.Generic;

namespace ProgrammingSchool.Classes
{
    class Teacher
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Course> TeachingCourses { get; set; }
        public Teacher(string id, string firstName, string lastName, string nationalId, DateTime birthday, string password, string phone, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NationalId = nationalId;
            Birthday = birthday;
            Password = password;
            Phone = phone;
            Address = address;
            TeachingCourses = new List<Course>();
            //send to db
        }
        public bool AddCourse(Course course)
        {
            TeachingCourses.Add(course);
            //TODO try connet server and return
            return true;
        }
        public bool DeleteCourse(Course course)
        {
            TeachingCourses.Remove(course);
            //send to db
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher teacher &&
                   Id == teacher.Id &&
                   FirstName == teacher.FirstName &&
                   LastName == teacher.LastName &&
                   NationalId == teacher.NationalId;
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

        public static bool operator ==(Teacher left, Teacher right)
        {
            return EqualityComparer<Teacher>.Default.Equals(left, right);
        }

        public static bool operator !=(Teacher left, Teacher right)
        {
            return !(left == right);
        }
    }
}
