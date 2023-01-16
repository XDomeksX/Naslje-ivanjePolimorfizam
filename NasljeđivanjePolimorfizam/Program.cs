using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljeđivanjePolimorfizam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dessert dessert = new Dessert("banana", 118, 105);
            Cake cake = new Cake("OnaCudnaRolada", 500, 400, true, "birthday");
            Console.WriteLine(dessert.getDessertType());
            Console.WriteLine(cake.getDessertType());

            Person p1 = new Person("Ivo", "Ivic", 20);
            Person p2 = new Person("Ivo", "Ivic", 20);
            Person p3 = new Student("Ivo", "Ivic", 20, "0036312123", (short)3);
            Person p4 = new Student("Marko", "Marić", 25, "0036312123", (short)5);
            Person p5 = new Student("Marko", "Marić", 25, "0036312123", (short)7);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p3.Equals(p4));
            Console.WriteLine(p3.Equals(p4));
            Console.WriteLine(p4.Equals(p5));

            Console.ReadKey();
        }
    }
}
