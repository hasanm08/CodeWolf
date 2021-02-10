using System.Collections.Generic;

namespace ProgrammingSchool.Classes
{
    class CourseDate
    {
        public string Day { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }

        public CourseDate(string day, int startHour, int startMinute, int endHour, int endMinute)
        {
            Day = day;
            StartHour = startHour;
            StartMinute = startMinute;
            EndHour = endHour;
            EndMinute = endMinute;
        }


        public override bool Equals(object obj)
        {
            return obj is CourseDate date &&
                   Day == date.Day &&
                   StartHour == date.StartHour &&
                   StartMinute == date.StartMinute &&
                   EndHour == date.EndHour &&
                   EndMinute == date.EndMinute;
        }

        public override int GetHashCode()
        {
            int hashCode = 554632650;
            hashCode = hashCode * -1521134295 + Day.GetHashCode();
            hashCode = hashCode * -1521134295 + StartHour.GetHashCode();
            hashCode = hashCode * -1521134295 + StartMinute.GetHashCode();
            hashCode = hashCode * -1521134295 + EndHour.GetHashCode();
            hashCode = hashCode * -1521134295 + EndMinute.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return Day +$" {StartHour}:{StartMinute}-{EndHour}:{EndMinute}";
        }

        public static bool operator ==(CourseDate left, CourseDate right)
        {
            return EqualityComparer<CourseDate>.Default.Equals(left, right);
        }

        public static bool operator !=(CourseDate left, CourseDate right)
        {
            return !(left == right);
        }
    }
}
