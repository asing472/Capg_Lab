using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class CreditLimitException: Exception
    {
        public CreditLimitException(string message):base(message)
        {

        }
    }
    class Customer
    {
        //fields
        private string _customerId;
        private string _customerName;
        private string _address;
        private string _city;
        private string _phone;
        private int _creditLimit;
        
        //properties
        public string CustomerId { get => _customerId; set => _customerId = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public int CreditLimit
        {
            set
            {
                if (value <= 50000)
                {
                    _creditLimit = value;
                }
                else
                {
                    throw new Exception("Credit limit must be less than 50000");
                }
            }

            get
            {
                return _creditLimit;
            }

        }

        public Customer()
        {
            CustomerId = "";
            CustomerName = "";
            Address = "";
            City = "";
            Phone = "";
            CreditLimit = 0;
          
        }

        public Customer(string CustomerId, string CustomerName, string Address, string City, string Phone, int CreditLimit)
        {
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
            this.Address = Address;
            this.City = City;
            this.Phone = Phone;
            this.CreditLimit = CreditLimit;
        }



    }
    class Program
    {     
        static void Main(string[] args)
        {
            try
            {
                Customer cust = new Customer();
                Console.WriteLine("Customer Id");
                cust.CustomerId = Console.ReadLine();
                Console.WriteLine("Customer Name");
                cust.CustomerName = Console.ReadLine();
                Console.WriteLine("Address");
                cust.Address = Console.ReadLine();
                Console.WriteLine("City");
                cust.City = Console.ReadLine();
                Console.WriteLine("Phone");
                cust.Phone = Console.ReadLine();
                Console.WriteLine("Credit Limit");
                cust.CreditLimit =Convert.ToInt32(Console.ReadLine()); 
            }

            catch(Exception ex)
            {

                String content = $"\n\n{DateTime.Now}" +
                    $"\nMessage: {ex.Message}";
                Console.WriteLine(content);

           

            }

            Console.ReadKey();

           
        }
    }
}





               


          
            