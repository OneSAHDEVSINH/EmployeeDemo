using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            emp.SetName(name);

            Console.WriteLine("Enter salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            emp.Salary = salary;
                        
            emp.CalculateBonus();
                        
            emp.CalculateNetSalary();

            Tuple<string, int, float, float> result = emp.GetData();

            Console.WriteLine("Name: " + result.Item1);
            Console.WriteLine("Salary: " + result.Item2);
            Console.WriteLine("Bonus: " + result.Item3);
            Console.WriteLine("Net Salary: " + result.Item4);
            Console.ReadKey();
        }
    }
}
