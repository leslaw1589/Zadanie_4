using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Jan", "Nowak", 100.0);

            emp1.RegisterTime(5);
            emp1.RegisterTime(10);
            emp1.RegisterTime(7.5);
            emp1.PaySalary();

            emp1.RegisterTime(11);
            emp1.PaySalary();


            Console.ReadKey();
        }
    }
}
