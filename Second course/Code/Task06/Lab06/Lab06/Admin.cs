using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Admin
    {
        List<Regular> regularList = new List<Regular>();
        List<Hourly> hourlyList = new List<Hourly>();

        public void addRegularEmp(Regular R) {

            regularList.Add(R);
        
        }

        public void addHourlyEmp(Hourly H) {
            hourlyList.Add(H);
        
        }

        public void printEmployeesInfo() {
            foreach (Regular r in regularList)
            {
                Console.WriteLine("***************");
                r.printinfo();
                Console.WriteLine("***************");
            }
            foreach (Hourly h in hourlyList)
            {
                Console.WriteLine("***************");
                h.printinfo();
                Console.WriteLine("***************");
            }
        }

        public void printHighestEarnings() {
            double max = 0;
            int indx = -1;

            foreach (Regular r in regularList) 
            {
                if (max <= r.earning()) {
                    max = r.earning();
                    indx = regularList.IndexOf(r);
                } 
            }

            Regular R;
            R = regularList[indx];
            Console.WriteLine("Highest Earning:");
            R.printinfo();
            


            double maxh = 0;
            int indxh = -1;

                foreach (Hourly h in hourlyList)
                {
                    if (maxh <= h.earning())
                    {
                        maxh = h.earning();
                        indxh = hourlyList.IndexOf(h);
                    }       
                
                }

            Hourly H;
            H = hourlyList[indxh];
            Console.WriteLine("Highest Earning: ");
            H.printinfo();
            




        }

        
    }
}
