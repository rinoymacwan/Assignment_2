using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    abstract class Employee
    {
        protected int id, experience, basicSalary;
        protected string name, designation;
        protected DateTime joiningDate;
        public Employee(string name, int basicSalary, int experience)
        {
            this.name = name;
            this.basicSalary = basicSalary;
            this.experience = experience;
        }
    }
}
