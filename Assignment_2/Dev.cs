using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Dev : Employee
    {
        int finalsalary;
        public Dev(string name, int basicSalary, int experience) : base(name, basicSalary, experience)
        {
            finalsalary = basicSalary + 2000 * experience;
        }

        public void Display()
        {
            Console.WriteLine("Salary of Dev " + name + " is " + finalsalary);
        }
    }
}
