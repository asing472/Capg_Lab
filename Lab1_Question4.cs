using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1_Question4
{
    class SchoolDemo
    {
        //fields
        private int rollNumber;
        private string studentName;
        private byte age;
        private char gender;
        private DateTime dateOfBirth;
        private string address;
        private float percentage;

        //properties
        public int RollNumber { get => rollNumber; set => rollNumber = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public byte Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public float Percentage { get => percentage; set => percentage = value; }

        public SchoolDemo()
        {
            RollNumber = 0;
            StudentName = "";
            Age = 0;
            Gender = '\0';
            DateOfBirth = DateTime.Now;
            Address = "";
            Percentage = 0.0F;
        }

        public SchoolDemo(int RollNumber,string StudentName,byte Age,char Gender,DateTime DateOfBirth,string Address,float Percentage)
        {
            this.RollNumber = RollNumber;
            this.StudentName = StudentName;
            this.Age = Age;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.Percentage = Percentage;
        }

    }
        

    class Program
    {
        public static void Main()
        {
            
            SchoolDemo sch = new SchoolDemo();

            Console.WriteLine("Enter details:");
            Console.WriteLine("Roll Number");
            sch.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student name");
            sch.StudentName = Console.ReadLine();
            Console.WriteLine("Age");
            sch.Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Gender");
            sch.Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Date of Birth");
            sch.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Address");
            sch.Address = Console.ReadLine();
            Console.WriteLine("Percentage");
            sch.Percentage = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            SchoolDemo sch2 = new SchoolDemo(sch.RollNumber,sch.StudentName,sch.Age,sch.Gender,sch.DateOfBirth,sch.Address,sch.Percentage);

            Console.WriteLine("Roll Number: " + sch.RollNumber);
            Console.WriteLine("Student name: " + sch.StudentName);
            Console.WriteLine("Age: " + sch.Age);
            Console.WriteLine("Gender: " + sch.Gender);
            Console.WriteLine("Date of Birth: " + sch.DateOfBirth);
            Console.WriteLine("Address: " + sch.Address);
            Console.WriteLine("Percentage: " + sch.Percentage);

            Console.ReadKey();

        }
        
    }
}
