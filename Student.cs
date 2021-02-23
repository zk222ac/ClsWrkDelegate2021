using System;
using System.Collections.Generic;
using System.Text;

namespace ClsWrkDelegate
{
   public class Student
    {
        private string _name;
        private int _grade;
        private int _age;

        public Student(string name, int age, int grade)
        {
            Name = name;
            Grade = grade;
            Age = age;
        }

        public string Name { get => _name; set => _name = value; }
        public int Grade { get => _grade; set => _grade = value; }
        public int Age { get => _age; set => _age = value; }


    }
}
