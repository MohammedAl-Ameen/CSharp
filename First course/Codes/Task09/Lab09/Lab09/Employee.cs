using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Employee
    {
        protected string name;
        protected int id;
        protected double baseSalary;

        public Employee(string name , int id , double baseSalary)
        {
            this.name = name;
            this.id = id;
            this.baseSalary = baseSalary;
        }

        public virtual double calculateSalary() {


            return baseSalary;
        
        }

        public virtual string printInfo() {

            if (name.Length > 7)
            {
                string info = $"{this.name}\t{this.id}";
                return info;
            }
            else
            {
                string info = $"{this.name}\t\t{this.id}";
                return info;
            }

           
        }

    }


    class Administrative : Employee
    {
        private int extraHour;
        public Administrative(int extraHour , string name, int id, double baseSalary) :base( name,  id, baseSalary)
        {
           
            this.extraHour = extraHour;


        }

        public override double calculateSalary()
        {
            return base.calculateSalary() + 3*this.extraHour;
        }

        public override string printInfo()
        {
            string info = "Name\t\tID\t\tSalary\t\tType\t\tExtra hours\n"; 
            info += base.printInfo();
            if (name.Length > 7)
            {
                info += $"\t\t{calculateSalary()}\t\tAdministrative\t{extraHour}\t\t\n\n";
                return info;
            }
            else
            {
                info += $"\t\t{calculateSalary()}\t\tAdministrative\t{extraHour}\t\t\n\n";
                return info;
            }
           

            
        }
    }

    class Academic : Employee
    {
        private int numCourses;
        public Academic(int numCourses ,  string name, int id, double baseSalary) : base(name, id, baseSalary)
        {
            this.numCourses = numCourses;

        }
        public override double calculateSalary()
        {
            return base.calculateSalary() * this.numCourses;
        }

        public override string printInfo() 
        {
            string info = "Name\t\tID\t\tSalary\t\tType\t\tNumber of Courses\n";
            info += base.printInfo();
            if (calculateSalary() > 7)
            {
                info += $"\t\t{calculateSalary()}\t\tAcademic\t\t{numCourses}\t\t\n\n";
                return info;
            }
            else
            {
                info += $"\t\t{calculateSalary()}\t\tAcademic\t\t{numCourses}\t\t\n\n";
                return info;
            }


           return info;
        }
    }


}
