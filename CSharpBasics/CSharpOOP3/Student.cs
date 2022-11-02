using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    public struct Student
    {
        private string _name;
        private string _surname;
        private int _age;

        public Student(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Student name: {_name}.\nStudent surname: {_surname}.\nStudent age: {_age}.");
        }
    }
}
