using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{

  
    class I_Print
    {
        public virtual void printInfo(Account c)
        {
           
        }
    }



    class Customer:I_Print
    {
        private string name;
        private int ID;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public void setCustomer(string name, int id)
        {
            Id = id;
            Name = name;
        }

        public override void printInfo(Account c) {
          
           
            Console.WriteLine("*****************************Customer info**********************************");
            Console.WriteLine("The customer name          The customer ID              The customer Balance ");
            Console.WriteLine("       {0}                            {1}                              {2}", Name , Id , c.Balance);
            Console.WriteLine("*****************************************************************************");


        }



    }

    class Account
    {
        private int balance;

        public int Balance
        {

            get { return balance; }
            set { balance = value; }

        }

        public void Deposit(int amount)
        {

            Balance += amount;


        }

        public void Withdraw(int amount)
        {

            if (Balance > amount)
                Balance = Balance - amount;
            else { Console.WriteLine("The process can't be completed, there is no enough balance"); }

        }




    }


    class Card
    {
        private int ID;
        private string password;

        public string Password
        {

            get { return password; }
            set { password = value; }

        }

        public int Id
        {

            get { return ID; }
            set { ID = value; }

        }

        public void setCard(int id, string pass) {
            Id = id;
            Password = pass;
        
        
        }


        public bool isValid(Customer c) {

      
            //foreach (Card d in  ) {
                if ((c.Id == Id) && (c.Name == Password))
                    return true;
        //    }
            
            return false;
        }


    }




    class ATM_FACADE {

        private Customer customer = new Customer();
        private Account account = new Account();
        private Card card = new Card();


        public void setCustomerInfo(string name, int id) {

            customer.Id = id;
            customer.Name = name;


        }
        public void setCardInfo(string pass, int id)
        {

            card.Id = id;
            card.Password = pass;
        }

        public void depositMony(int amount) {
          
            
            account.Balance += amount;
        
        
        }

        public void winthdrawMony (int amount){

            if (account.Balance > amount)
            {
                account.Balance -= amount;
            }
            else { Console.WriteLine("There is no enough balance in this account"); }
        
        }

        public void printCustomerInfo() {

            customer.printInfo(account);
        
        }




    }


}
