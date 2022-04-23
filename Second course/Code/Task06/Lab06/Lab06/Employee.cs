using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    abstract class Employee
    {
        protected string name;
        protected int id;

        public string Name {
            set { name = value; }
            get { return name; }
        }

        public int ID
        {
            set{ id = value; }
            get { return id; }
        }

        public abstract double earning();

        public abstract void printinfo();


    }


    class Regular : Employee {

        private double weeklySalary;

        public double WeeklySalary
        {
            set { weeklySalary = value; }
            get { return weeklySalary; }
        }

        public override double earning()
        {
            return weeklySalary * 4;
        }

        public override void printinfo()
        {
            Console.WriteLine("Regular employee: \nname: {0} \nid: {1} \nearning: {2}", name , ID , earning());
        }

    }

    class Hourly : Employee
    {

        private double hourlyRate;
        private int hours;

        public double HourlyRate
        {
            set { hourlyRate = value; }
            get { return hourlyRate; }
        }

        public int Hours {

            set { hours = value; }
            get { return hours; }
        }


        public override double earning()
        {
            return hours * hourlyRate;
        }

        public override void printinfo()
        {

           
            Console.WriteLine("Hourly employee: \nname: {0} \nid: {1} \nearning: {2}", name, id, earning());
           
        }

    }


}
