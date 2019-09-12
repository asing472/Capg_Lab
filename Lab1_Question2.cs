using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            ArithmeticOperations arit = new ArithmeticOperations();
            Console.WriteLine("Enter i for int and d for double:");
            String choice1 = Console.ReadLine();

            //int choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice1 == "i")
            {
                Console.WriteLine("Enter 1 for addition, 2 for substraction, 3 for multiplication, 4 for division and 5 for modulus:");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the numbers for addition:");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(arit.Addition(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the numbers for substraction:");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(arit.Subtraction(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the numbers for multiplication:");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(arit.Multiplication(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the numbers for division:");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(arit.Division(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter the numbers for modulus:");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(arit.Modulus(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                }
            }

            if (choice1 == "d")
            {
                Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division and 5 for modulus:");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the numbers for addition:");
                            double n1 = Convert.ToDouble(Console.ReadLine());
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(arit.Addition(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the numbers for subtraction:");
                            double n1 = Convert.ToDouble(Console.ReadLine());
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(arit.Subtraction(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the numbers for multiplication:");
                            double n1 = Convert.ToDouble(Console.ReadLine());
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(arit.Multiplication(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the numbers for division:");
                            double n1 = Convert.ToDouble(Console.ReadLine());
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(arit.Division(n1, n2));
                            Console.ReadKey();

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter the numbers for modulus:");
                            double n1 = Convert.ToDouble(Console.ReadLine());
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(arit.Modulus(n1, n2));
                            Console.ReadKey();

                            break;
                        }

                }

            }
        }
    }
}
