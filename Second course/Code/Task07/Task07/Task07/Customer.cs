using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07
{
    abstract class Customer
    {
        public string Type;
        public int Account_Num;
        public double consumption;




        public abstract double CalculateBill();

    }


    class Household : Customer
    {

       
        public Household()
        {
           
           Type = "Customer";
            Account_Num = 0;
            consumption = 0;



        }



        public override double CalculateBill()
        {
            if (consumption >= 160)
            {


                return consumption * 0.072;

            }
            else if (consumption < 160)
            {

                return consumption * 0.086;

            }
            else { return 0; }


        }
    }



    class Business : Customer
    {

      
        public Business()
        {
            Type = "Customer";
            Account_Num = 0;
            consumption = 0;

        }




        public override double CalculateBill()
        {


            if (consumption >= 160)
            {


                return consumption * 0.079;

            }
            else if (consumption < 160)
            {

                return consumption * 0.086;

            }
            else { return 0; }

        }
    }

    class AccountsFactory
    {



        public Customer GetAcount(int ID)
        {
            if (ID == 1) { return new Household(); }
            else if (ID == 2) { return new Business(); }
            else return null;
        }

    }
}

