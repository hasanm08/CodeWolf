using System.Collections.Generic;

namespace ProgrammingSchool.Classes
{
    class Class
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Class(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is Class @class &&
                   Id == @class.Id &&
                   Name == @class.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public static bool operator ==(Class left, Class right)
        {
            return EqualityComparer<Class>.Default.Equals(left, right);
        }

        public static bool operator !=(Class left, Class right)
        {
            return !(left == right);
        }
    }
}
