using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07
{
	class Program
	{
		static void Main(string[] args)
		{
			AccountsFactory factory = new AccountsFactory();
			Manager a = Manager.getManager();

			int ID;

		

			int x;
			while (true)
			{
				Console.WriteLine("******************");
				Console.WriteLine("\n  1::Add Customer  ");
				Console.WriteLine("  2::Print Earnings");
				Console.WriteLine("  3::Exit\n");
				Console.WriteLine("******************");

				Console.Write("\nYour choice is : ");
				x = Convert.ToInt32(Console.ReadLine());
				switch (x)
				{
					case 1:

						Console.Write("\n Enter the type of account  : ");
						ID = Convert.ToInt32(Console.ReadLine());
						Customer obj = factory.GetAcount(ID);

						Console.WriteLine("\n Enter the account info  : ");
						Console.Write("  Account Number  : ");
						obj.Account_Num = Convert.ToInt32(Console.ReadLine());
						Console.Write("Account consumption  : ");
						obj.consumption = Convert.ToInt32(Console.ReadLine());



						a.addCustomer(obj);

						break;
					case 2:

						a.PrintEarning();
						break;

					case 3:
						Environment.Exit(0);
						
						break;
				}
			}
		}
	}
}
