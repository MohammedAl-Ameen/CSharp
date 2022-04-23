using System;
using System.Collections.Generic;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.WriteLine("***********");
                Console.WriteLine("1.Repeating numbers");
                Console.WriteLine("2.Encryption");
                Console.WriteLine("3.email is a valid or invalid");
                Console.WriteLine("4.Exit");
                Console.WriteLine("***********");
                Console.Write("Please enter you choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {

                    case 1:
                    repeating();
                        break;

                    case 2:
                        four();
                        break;

                    case 3:
                        email();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                } }


        }

        public static void repeating() {

            List<int> a = new List<int>();
            List<int> b = new List<int>();
            List<int> c = new List<int>();
            int choice;
          
            Console.WriteLine("Please enter your first list, Enter 404 to exit the first list");
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 404) {

                    a.Add(choice);
                    choice = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine("Please enter your second list, Enter 404 to exit the second list");
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 404)
            {

                b.Add(choice);
                choice = Convert.ToInt32(Console.ReadLine());

            }

            foreach (int num in a) {
                c.Add(num);
            }


            foreach (int num in b)
            {
                if (!c.Contains(num)) {
                    c.Add(num);
                } else { continue; }

     

            }

            c.Sort();
            foreach (int num in c) {
                Console.WriteLine("{0}",num);
            
            }


        }

        public static void four() {
            Console.Write("Please enter your number, The number must be 4-digit: ");
            int num0;
            num0 = Convert.ToInt32(Console.ReadLine());
            int num1, num2, num3, num4, swap, num;

            num1 = num0 % 10;
            num2 = num0 % 100;
            num2 = num2 / 10;
            num3 = num0 % 1000;
            num3 = num3 / 100;
            num4 = num0 / 1000;


            num1 = (num1 + 7) % 10;
            num2 = (num2 + 7) % 10;
            num3 = (num3 + 7) % 10;
            num4 = (num4 + 7) % 10;

            swap = num1;
            num1 = num3;
            num3 = swap;
            swap = num4;
            num4 = num2;
            num2 = swap;

            num = num1 + num2 * 10 + num3 * 100 + num4 * 1000;

            Console.WriteLine("The encrypting number: {0}",num);



        }


        public static void email() {
            Console.WriteLine("Please enter you e-mail");
            string str = Console.ReadLine();
            string[] sub = str.Split('@');
            if (sub.Length == 1) {
                Console.WriteLine("The email is Invalid, add a domain");
            } else if (sub.Length == 2) {
                if (valid(sub[0]))
                {
                    string[] sub1 = str.Split('.');
                    if (sub1.Length == 2)
                    {
                        if (sub1[1] == "com" || sub1[1] == "org")
                        {

                            Console.WriteLine("Your e-mail is valid");

                        }
                        else {

                            Console.WriteLine("The domain is Invalid");
                        
                        }

                    }
                    else {
                        Console.WriteLine("The domain Invalid");
                    
                    }

                }
                else {
                    Console.WriteLine("The prefix is Invalid");
                }

        
               
            
            } else if (sub.Length > 2) {
                Console.WriteLine("The email have a more than one domain!!");

            }
        
        
        }

        public static bool valid (string str) {
          
            str.ToLower();
            foreach (char num in str)
            {

                if (!(('a' <= num && num <= 'z') || ('0' <= num && num <= '9')))
                {

                    return false;


                }
            }

            return true;
        }
    }

}
