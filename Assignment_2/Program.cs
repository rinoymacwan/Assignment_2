using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HR emp1 = new HR("Yesha", 8000, 4);
            Dev emp2 = new Dev("Rinoy", 8000, 5);
            emp1.Display();
            emp2.Display();
            Console.ReadKey();
        }
    }
}
