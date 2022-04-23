using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class contact
    {
       private string name, address, PersonType;
       private List<int> PhoneNumber = new List<int>();


        public contact() {

            name = "";
            address = "";
            PersonType = "";
            
      
        }

        public contact(string Name, string Address, string persontype, List<int> phonenumber)
        {

            name = Name;
            address = Address;
            PersonType = persontype;
            PhoneNumber = phonenumber;
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string personType
        {
            get
            {
                return PersonType;
            }
            set
            {
                PersonType = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }


        public List<int> phoneNumber
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                PhoneNumber = value;
            }
        }



        public void Printinfo() {

            
            Console.Write("{0} {1} {2} ", name, address, PersonType);

            foreach (int num in PhoneNumber) {

                Console.Write(" 0{0} " , num);
            }

            Console.WriteLine();

        }


        public bool isExist(int num) {

            foreach (int num1 in PhoneNumber) {
                if (num1 == num) {
                    return true;
                } }
            return false;

        }

        public int PhoneCount() {

            return PhoneNumber.Count;

        }



    }
}
