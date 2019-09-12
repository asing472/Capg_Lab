using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Que1
{
    class Employee
    {
        //fields
        private string _employeeId;
        private string _employeeName;
        private string _address;
        private string _city;
        private string _department;
        private int _salary;

        //properties
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string Department { get => _department; set => _department = value; }
        public int Salary{ get => _salary; set => _salary = value; }

        public Employee()
        {
            EmployeeId = "";
            EmployeeName = "";
            Address = "";
            City = "";
            Department = "";
            Salary = 0;

        }


    }
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter details:");
                Employee empl = new Employee();
                Console.WriteLine("Employee Id");
                empl.EmployeeId = Console.ReadLine();
                Console.WriteLine("Employee Name");
                empl.EmployeeName = Console.ReadLine();
                Console.WriteLine("Address");
                empl.Address = Console.ReadLine();
                Console.WriteLine("City");
                empl.City = Console.ReadLine();
                Console.WriteLine("Department");
                empl.Department = Console.ReadLine();
                Console.WriteLine("Salary");
                empl.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                
                Console.WriteLine("Employee Name: "+ empl.EmployeeName);
                Console.WriteLine("Salary: "+ empl.Salary);
                Console.WriteLine("\n");

            }
            Console.ReadKey();
        }
    }
}











