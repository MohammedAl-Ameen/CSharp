using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{ 
  // Part 01
   
    class AverageClass
    {
     

        public double avg(int x , int y , int z)
        {

        

            return (x + y + z)/3;
        }

  
        }    


    class DiscountClass
    {
        public double Discount(double amount)
        {
            double amount2 = 0;

            if (amount >= 50)
            {
                amount2 = amount - (amount * (20 / 100));
                return amount2;
            }
            else if (amount < 50 && amount >= 20)
            {
                amount2 = amount - (amount * (10 / 100));
                return amount2;
            }
            else return amount;
        }
    }

    //Part 02

    class OperationClass
    {
        public AverageClass AverageOperation = new AverageClass();
        public DiscountClass DiscountOperation = new DiscountClass();

        public double operation(int N1 , int N2 , int N3)
        {
            return DiscountOperation.Discount(AverageOperation.avg(N1,N2,N3));
        }




    }
}
