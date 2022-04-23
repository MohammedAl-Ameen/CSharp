using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM_FACADE atm = new ATM_FACADE();
            Card d = new Card();
            string name;
            int amount, x, id;
            Customer c = new Customer();



            do
            {

                Console.WriteLine("*****Please insert customer info***** \n");



                Console.Write("Insert the customer Name:   ");
                name = Console.ReadLine();
                c.Name = name;
                Console.Write("insert the customer ID:     ");
                id = Convert.ToInt32(Console.ReadLine());
                c.Id = id;
                Console.WriteLine();

                atm.setCustomerInfo(name, id);

                Console.WriteLine("*****Please insert card info***** \n");

                Console.Write("Insert the card id:    ");
                id = Convert.ToInt32(Console.ReadLine());
                d.Id = id;
                Console.Write("Insert the card password:    ");
                name = Console.ReadLine();
                d.Password = name;
                Console.WriteLine();

                atm.setCardInfo(name, id);

                 Console.WriteLine("The password and the ID are not valid, Please try agian");
                 Console.WriteLine();
                Console.WriteLine();



            } while (!d.isValid(c));


                while (true)
                {







                    Console.WriteLine("******************");
                    Console.WriteLine("  1::Deposit Money.  ");
                    Console.WriteLine("  2::Withdraw Money. ");
                    Console.WriteLine("  3::Print Info.");
                    Console.WriteLine("  4::Exit\n");
                    Console.WriteLine("******************");

                    Console.Write("\nEnter you choice please: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {

                        case 1:

                            Console.Write("\nPlease inserts the amount of money:     ");
                            amount = Convert.ToInt32(Console.ReadLine());
                            atm.depositMony(amount);
                            break;

                        case 2:

                            Console.Write("\nPlease inserts the amount of money:     ");
                            amount = Convert.ToInt32(Console.ReadLine());
                            atm.winthdrawMony(amount);
                            break;

                        case 3:
                            atm.printCustomerInfo();
                            break;

                        case 4:
                            return;
                            break;




                    }





                }

            }
        }
    }

