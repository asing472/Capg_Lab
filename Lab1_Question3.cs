using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1_Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer from 1 to 5:");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {

                case 1:
                    {
                        Console.WriteLine("The integer entered is 1");
                        Console.ReadKey();

                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("The integer entered is 2");
                        Console.ReadKey();

                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("The integer entered is 3");
                        Console.ReadKey();

                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("The integer entered is 4");
                        Console.ReadKey();

                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("The integer entered is 5");
                        Console.ReadKey();

                        break;
                    }

                default:
                    {
                        Console.WriteLine("The integer entered is not among one in the above choices");
                        Console.ReadKey();

                        break;
                    }
            }
        }
    }
}
