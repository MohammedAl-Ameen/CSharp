using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin a = new Admin();
            int choice;

            while (true) {

                Console.WriteLine("***************");
                Console.WriteLine("1. Add Regular Employee");
                Console.WriteLine("2. Add Hourly Employee.");
                Console.WriteLine("3. Print employees info.");
                Console.WriteLine("4. Print employees with highest earnings.");
                Console.WriteLine("5. Exit");
                Console.WriteLine("***************");

                Console.WriteLine("Please Enter your choice");
              //  System.Threading.Thread.Sleep(2000); 
                Console.Write("Your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n ");

                switch (choice) 
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the name of the Employee ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the id of the Employee");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the weekly salary for the Employee");
                            double salary = Convert.ToInt32(Console.ReadLine());

                            Regular r = new Regular();
                            r.Name = name;
                            r.ID = id;
                            r.WeeklySalary = salary;
                            a.addRegularEmp(r);

                            Console.WriteLine("\n");

                            break;
                        }


                    case 2:

                        {
                            Console.WriteLine("Enter the name of the Employee ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the id of the Employee");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the hourly salary for the Employee");
                            double salary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the hours for the Employee");
                            int hours = Convert.ToInt32(Console.ReadLine());


                            Hourly h = new Hourly();
                            h.Name = name;
                            h.ID = id;
                            h.HourlyRate = salary;
                            h.Hours = hours;
                            a.addHourlyEmp(h);


                            Console.WriteLine("\n");

                            break;
                        }


                    case 3:
                        
                        {
                            Console.WriteLine("*******INFO********");
                            a.printEmployeesInfo();
                            Console.WriteLine("*******INFO********");
                            Console.WriteLine("\n");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("*******HIGHEST_EARNING********");
                            a.printHighestEarnings();
                            Console.WriteLine("*******HIGHEST_EARNING********");
                            Console.WriteLine("\n");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Good bye...");
                            System.Threading.Thread.Sleep(3500);
                            Environment.Exit(0);
                            break;
                        }
                        
                }

                










            }


        }
    }
}
