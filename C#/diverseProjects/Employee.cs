using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diverseProjects
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;

        public Employee(int id, string name, double salary) {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public int GetId() {
            return _id;
        }

        public string GetName() {
            return (_name ?? "");
        }

        public double GetSalary() {
            return _salary;
        }

        public void RaiseSalary(double percentage) {
            _salary = _salary + (_salary * (percentage / 100));
        }
    }
}
