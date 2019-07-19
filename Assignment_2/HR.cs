using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class HR: Employee
    {
        int finalsalary;
        public HR(string name, int basicSalary, int experience):base(name, basicSalary, experience)
        {
            
            finalsalary = basicSalary + 1000 * experience;
        }
        
        public void Display()
        {
            Console.WriteLine("Salary is HR rep " + name +" is "+ finalsalary);
        }
    }
}
