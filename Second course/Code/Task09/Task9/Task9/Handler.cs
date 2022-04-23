using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    abstract class Handler
    {
        public Handler handler;
        public double cost;

        public void setSuccessor(Handler next)
        {
            handler = next;
        }

        public abstract void clalculate(string type, int consumption);
        
  
    }


    class BRACKET_3:Handler
    {
        public override void clalculate(string type, int consumption)
        {
            if (consumption > 300 && type == "household") {
                cost = (consumption-300) * 0.086;
                handler.clalculate("household", 300);
            
            } else if(consumption > 300 && type == "business") {

                cost = (consumption - 300) * 0.095;
                handler.clalculate("business", 300);


            } else if (type == "household") {
                handler.clalculate("household", consumption);

            } else if (type == "business")
            {
                handler.clalculate("business", consumption);
            }
        }
    }

    class BRACKET_2 : Handler
    {
        public override void clalculate(string type, int consumption)
        {
            if ((consumption > 160 || consumption <= 300) && type == "household")
            {
                cost = (consumption - 160) * 0.072;
                handler.clalculate("household", 160);

            }
            else if ((consumption > 160 || consumption <= 300) && type == "business")
            {

                cost = (consumption - 160) * 0.079;
                handler.clalculate("business", 160);


            }
            else if (type == "household")
            {
                handler.clalculate("household", consumption);

            }
            else if (type == "business")
            {
                handler.clalculate("business", consumption);
            }
        }




    }

    class BRACKET_1 : Handler
    {
        public override void clalculate(string type, int consumption)
        {
            if ((consumption >= 0 || consumption <= 160))
            {
                cost = (consumption) * 0.033;
              
            }
     
            else
            {
                Console.WriteLine("Wrong input");
            }
        }




    }
}
