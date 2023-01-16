using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljeđivanjePolimorfizam
{
    internal class Student : Person
    {
        string studentID;
        short academicYear;

        public Student(string name, string surname, int age, string studentID, short academicYear) : base(name, surname, age)
        {
            this.studentID = studentID;
            this.academicYear = academicYear;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public short AcademicYear { get => academicYear; set => academicYear = value; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   base.Equals(obj) &&
                   studentID == student.studentID;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.studentID + " " + this.academicYear;
        }
    }
}
