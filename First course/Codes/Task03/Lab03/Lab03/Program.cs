using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {

            List<contact> Book = new List<contact>();
            contact contact = new contact();
        
            int choice, count = 0;
            bool flag = false;








            while (true) {
                Console.WriteLine("************");
                Console.WriteLine("1.Add a new contact to the address book.");
                Console.WriteLine("2.Remove a contact from the address book based on a person’s name. ");
                Console.WriteLine("3.Add Phone number to a specific contact based on a person’s name.");
                Console.WriteLine("4.Count the total number of phone numbers in the address book.");
                Console.WriteLine("5.Count the number of phone numbers in the address book based on the type of theperson.");
                Console.WriteLine("6.Count the number of friends’ contacts in a specific city.");
                Console.WriteLine("7.Print person’s info.");
                Console.WriteLine("8.Search for a phone and print the info of the person.");
                Console.WriteLine("9.Print all info in the address book.");
                Console.WriteLine("10.Exit");
                Console.WriteLine("************");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {

                    case 1:
                        string name, address, persontype, phoneS;
                        int phone;
                       // Console.WriteLine("Notice for spaces");
                        Console.Write("Please enter the Name: ");
                        name = Console.ReadLine();
                        //  name = String.Concat(name.Where(c => !Char.IsWhiteSpace(c)));
                        name = name.Trim();
                        Console.Write("Please enter the Address: ");
                        address = Console.ReadLine();
                        address = address.Trim();
                        Console.Write("Please enter the Person Type: ");
                        persontype = Console.ReadLine();
                        persontype = persontype.Trim();
                        Console.Write("Please enter the phone number: ");
                        phoneS = Console.ReadLine() ;
                        if (phoneS.Length != 10)
                        {
                            Console.WriteLine("The phone number is Invalid");
                        }
                        else
                        {
                            List<int> PhoneNumber = new List<int>();

                            phone = Convert.ToInt32(phoneS);
                            PhoneNumber.Add(phone);
                            //   contact.personType = persontype;
                            //   contact.Name = name;
                            //  contact.phoneNumber.Add(phone);
                            // contact.Address = address;
                            contact = new contact(name.ToLower(), address.ToLower(), persontype.ToLower(), PhoneNumber);
                         
                            Book.Add(contact);
                           
                          
                        }

                  


                        break;


                    case 2:
                        Console.Write("Please enter the name you need to delete: ");
                        name = Console.ReadLine();
                       
                        
                        foreach (contact obj in Book) {

                            if (obj.Name == name) {
                                flag = true;
                            
                            }
                        }

                        if (flag)
                        {

                            Book.RemoveAll(obj => obj.Name == name);
                            Console.WriteLine("The process was done successfully ");

                        }
                        else
                        {

                            Console.WriteLine("The name was not found");

                        }

                        flag = false;
                        break;

                    case 3:
                        Console.Write("Please enter the name you need to add: ");
                        name = Console.ReadLine();

                        foreach (contact obj in Book) 
                        {
                            if (obj.Name == name)
                            {
                                Console.Write("Please enter the phone number you wish to add: ");
                                phone = Convert.ToInt32(Console.ReadLine());
                                
                                obj.phoneNumber.Add(phone);
                                flag = true;
                                Console.WriteLine("The process was done successfully ");

                            }

                        }

                        if (!flag) {
                            Console.WriteLine("The name was not found");
                            
                        }

                        flag = false;

                        break;

                    case 4:

                        foreach (contact obj in Book)
                        {
                           
                                count = count + obj.PhoneCount(); 
                            
                        }
                        Console.WriteLine("The total is {0}", count);
                        count = 0;
                        break;


                    case 5:
                     
                        Console.WriteLine("Please enter the person type");
                        persontype = Console.ReadLine();

                        foreach (contact obj in Book) {
                            if (obj.personType == persontype) {
                                count = count + obj.PhoneCount();
                                flag = true;
                            }
                        
                        }

                        if (flag)
                        {
                            Console.WriteLine("The total is {0}", count);
                        }
                        else {
                            Console.WriteLine("The persontype wasn not found! ");
                        }


                        count = 0;
                        flag = false;
                        break;


                    case 6:
                        persontype = "friend";
                        Console.WriteLine("Enter the Address of the friend");
                        address = Console.ReadLine();
                        foreach (contact obj in Book) {
                            if ((obj.personType == persontype) && (obj.Address == address) ){
                                count++;
                                flag = true;

                            }
                        
                        }

                        if (flag)
                        {
                            Console.WriteLine("The total is {0}", count);
                        }
                        else
                        {
                            Console.WriteLine("Your don't have friends :( ");
                        }


                        count = 0;
                        flag = false;
                        break;



                    case 7:
                        Console.Write("Please enter the name you need to show: ");
                        name = Console.ReadLine();
                        foreach (contact obj in Book) {
                            if (obj.Name == name) {
                                obj.Printinfo();
                                flag = true;
                                
                            }
                        
                        
                        }

                        if (!flag)
                        {
                            Console.WriteLine("The name was not found");
                        
                        }


                        flag = false;
                        break;


                    case 8:

                        Console.Write("Please enter the phone number: ");
                        phone = Convert.ToInt32(Console.ReadLine());

                        foreach (contact obj in Book) {
                            foreach (int num in obj.phoneNumber) {
                                if (num == phone) {

                                    obj.Printinfo();

                                    flag = true;
                                }
                            
                            }
                        }

                        if (!flag) {

                            Console.WriteLine("The phone number was not found");
                        
                        }
                        phone = 0;
                        flag = false;
                        break;

                    case 9:
                        if (Book.Any())
                        {
                            foreach (contact obj in Book)
                            {
                                obj.Printinfo();
                                Console.WriteLine();


                            }
                        }
                        else {
                            Console.WriteLine("The list is Empty");
                        
                        }
                        break;

                     
                    case 10:
                        Environment.Exit(0);
                        break;
                       



                }

            }
            



        }
    }
}
