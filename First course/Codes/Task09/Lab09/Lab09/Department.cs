using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Department
    {
        private List<Employee> employees;

        public Department(){

            employees = new List<Employee>();
        
        }

        public void addEmployee(Employee e)
        {

            employees.Add(e);


        }

        public string printEmployeesInfo()
        {
            string info = "";
            foreach (Employee e in employees) {

                info += e.printInfo();
            
            }

            return info;

        }
    }
}
