using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07
{
    sealed class Manager
    {
        static Manager manager = new Manager();
        List<Customer> customerList;


        Manager()
        {
            customerList = new List<Customer>();
        }
        public static Manager getManager()
        { return manager; }

        public void addCustomer(Customer c)
        {
            customerList.Add(c);
        }

        public void PrintEarning()
        {
            double earning = 0;
            Console.WriteLine("Account Number          Type          Consumption          Bill          ");
            foreach (Customer e in customerList)
            {
                earning = e.CalculateBill() + earning;
                Console.WriteLine("{0}                      {1}             {2}             {3}          ", e.Account_Num , e.Type, e.consumption, e.CalculateBill());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Earnings = {0}", earning);

        }

    }
}
