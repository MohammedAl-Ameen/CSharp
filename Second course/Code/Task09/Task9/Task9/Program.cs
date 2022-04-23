using System;
using System.Collections.Generic;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {

          //  List<int> con = new List<int>();
          //  List<double> cost = new List<double>();



            Handler h1 = new BRACKET_1();
            Handler h2 = new BRACKET_2();
            Handler h3 = new BRACKET_3();


            h3.setSuccessor(h2);
            h2.setSuccessor(h1);
            int choice;
            int consuption;
            string type;
            double totalcost;
            
     

            while (true) {

                Console.WriteLine("******************");
                Console.WriteLine("  1::Enter the amount of consumption.  ");
                Console.WriteLine("  2::print the total cost. ");
                Console.WriteLine("  3::Exit\n");
                Console.WriteLine("******************");

                Console.Write("\nEnter you choice please: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                      //  counter++;
                        Console.WriteLine("Please enter the type, if eather Household or Business");
                        type = Console.ReadLine();
                        Console.WriteLine("Please enter the amount of consuption");
                        consuption = Convert.ToInt32(Console.ReadLine());
                       h3.clalculate(type.ToLower(), consuption);
                      //  con.Add(consuption);
                     
                       
                        break;

                    case 2:
                        totalcost = h3.cost + h2.cost + h1.cost; 
                        Console.WriteLine("The total cost is: {0}" , totalcost);
                   
                        break;

                  

                    case 3:
                        return;
                        break;




                }








            }



        }
    }
}
