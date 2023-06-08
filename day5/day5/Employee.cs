using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Employee
    {
        private static int nextId = 1;

        public int Id;
        private string _fullname;
        private int _department;
        private double _salary;


        public Employee(string fullname, int department, double salary)
        {

            _fullname = fullname;
            _department = department;
            _salary = salary;

            Id = nextId;
            nextId++;
        }

        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public string Fullname
        {
            get => _fullname;
            set => _fullname = value;
        }

        public int Department
        {
            get => _department; 
            set => _department = value;
        }

        

        

    }
}