using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, input;
            double saving_ratio, average_saving, average_income, average_expenses;

            while (true)
            {

                Console.WriteLine("*****************");
                Console.WriteLine("1.The information");
                Console.WriteLine("2.The number of the days");
                Console.WriteLine("3.The savings ratio calculator app ");
                Console.WriteLine("4.Exit");
                Console.WriteLine("***************** \n");

                Console.Write("Please enter you choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {


                    case 1:


                        Console.WriteLine("Name: Mohammed \nID: 2017980073\nMagor: Computer Engineering\nPlace of residence: Irbid \n\n\n ");

                        break;

                    case 2:

                        Console.Write("Please enter the number: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        if (input > 0 && input < 6) { Console.WriteLine("Working day \n \n"); } else if ((input == 6) || (input == 7)) { Console.WriteLine("weekend \n \n"); } else { Console.WriteLine("invalid \n \n"); }

                        break;


                    case 3:

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Please enter the average income: ");
                        average_income = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter the average expenses: ");
                        average_expenses = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                     
                        if (average_income < average_expenses) { Console.WriteLine("invalid value the expenses is more than the income \n\n\n"); break; }
                        average_saving = average_income - average_expenses;
                        saving_ratio = average_saving / average_income;

                        if (saving_ratio <= 0.2)
                        {
                            Console.WriteLine("Your monthly saveing is: {0}\nYour saving ratio is: {1}", saving_ratio, average_saving);
                            Console.WriteLine("You are Low on Savings\n");
                        }
                        else if (saving_ratio > 0.20 && saving_ratio <= 0.4)
                        {
                            Console.WriteLine("Your monthly saveing is: {0}\nYour saving ratio is: {1}", saving_ratio, average_saving);
                            Console.WriteLine("You are moderate on Savings\n");
                        }
                        else if (saving_ratio > 0.4 && saving_ratio <= 0.75)
                        {
                            Console.WriteLine("Your monthly saveing is: {0}\nYour saving ratio is: {1}", saving_ratio, average_saving);
                            Console.WriteLine("You are strong on Savings\n");
                        }
                        else if (saving_ratio > 0.75)
                        {
                            Console.WriteLine("Your monthly saveing is: {0}\nYour saving ratio is: {1}", saving_ratio, average_saving);
                            Console.WriteLine("You are mad about Savings\n");
                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;


                }
            }
        }
    }
}
