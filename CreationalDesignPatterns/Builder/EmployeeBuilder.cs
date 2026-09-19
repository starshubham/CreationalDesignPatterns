using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPatterns.Builder
{
    public class EmployeeBuilder
    {
        private Employee _employee = new Employee();

        // return this;
        // enables method chaining
        public EmployeeBuilder SetName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public EmployeeBuilder SetRole(string role)
        {
            _employee.Role = role;
            return this;
        }
        public EmployeeBuilder SetExperience(int experience)
        {
            _employee.Experience = experience;
            return this;
        }

        public EmployeeBuilder SetLocation(string location)
        {
            _employee.Location = location;
            return this;
        }

        public EmployeeBuilder SetSalary(decimal salary)
        {
            _employee.Salary = salary;
            return this;
        }

        public Employee Build()
        {
            return _employee;
        }
    }
}
