using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljeđivanjePolimorfizam
{
    internal class Teacher : Person
    {
        string email, subject;
        double salary;

        public Teacher(string name, string surname, int age, string email, string subject, double salary) : base(name, surname, age)
        {
            this.email = email;
            this.subject = subject;
            this.salary = salary;
        }

        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return base.ToString() + " " + this.email + " " + this.subject + " " + this.salary;
        }
        public override bool Equals(object obj)
        {
            return obj is Teacher teacher && base.Equals(obj) && email == teacher.email;
        }
        public void incraseSalary(int number)
        {
            this.salary = this.salary * ((number / 100) + 1);

        }
        public static void incraseSalary(int number, params Teacher[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i].incraseSalary(number);
            }
        }
    }
}
