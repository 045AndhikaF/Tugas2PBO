using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDANSuper
{
    //This
    class Student
    {
        private string username;
        private string password;

        public Student(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void printStudent()
        {
            Console.WriteLine("Username: {0}\nPassword: {1}", username, password);
        }
    }
    //Super/Base
    public class Person
    {
        protected string name = "Muhammad Andhika Fahrezzy";
        protected int age = 19;

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
        }
    }
    class Employee : Person
    {
        public string salary = "Rp. 17.000.000";
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Salary: {0}", salary);
        }
    }
    class TestClass
    {
        static void Main()
        {
            Console.WriteLine("Super/Base");
            Employee E = new Employee();
            E.GetInfo();
            Console.WriteLine("");
            Console.WriteLine("This");
            Student S = new Student("Andhika", "045");
            S.printStudent();
        }
    }
}