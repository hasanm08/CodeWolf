using System;
using System.Collections.Generic;

namespace ProgrammingSchool.Classes
{
    class Manager
    {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Manager(string id, string firstName, string lastName, string nationalId, DateTime birthday, string email, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NationalId = nationalId;
            Birthday = birthday;
            Email = email;
            Address = address;
        }
        public override bool Equals(object obj)
        {
            return obj is Manager manager &&
                   Id == manager.Id &&
                   FirstName == manager.FirstName &&
                   LastName == manager.LastName &&
                   NationalId == manager.NationalId;
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

        public static bool operator ==(Manager left, Manager right)
        {
            return EqualityComparer<Manager>.Default.Equals(left, right);
        }

        public static bool operator !=(Manager left, Manager right)
        {
            return !(left == right);
        }
    }
}
