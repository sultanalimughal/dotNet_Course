using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.AbstractionUserCase
{
    public class Student : Assignment
    {
        public Student(string _name)
        {
            Name = _name;
        }
        //public string Name { get; private set; }
        //public string Department { get; private set; }
        private string name;

        public string Name
        {
            get { return name; }
            private set {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                name = value; 
            }
        }

        public override decimal Marks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void PerformAssignment()
        {
            Console.WriteLine("Today Convering OOP Pillers");
            //throw new NotImplementedException();
        }
        public override decimal AssignmentMarks(decimal _marks)
        {
            return Marks = _marks + 100; //base.AssignmentMarks(_marks + 5);
        }
        public override string ToString()
        {
            return base.ToString() + $"Student Name is {name}";
        }

        //Overloading - Methods
        public int AddNumbers(int _number1 , int _number2)
        {
            return _number1 + _number2;
        }
        public int AddNumbers(int _number1, int _number2 , int _number3)
        {
            return _number1 + _number2 + _number3;
        }

    }
}
