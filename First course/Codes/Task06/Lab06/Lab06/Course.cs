using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Course
    {
        List<string> names;
        List<int> marks;

        public Course()
        {

            names = new List<string>();
            marks = new List<int>();

        }

        public void addstudent(string name, int mark)
        {
            name =  name.ToLower();
            name = name.Trim();
            if (names.IndexOf(name) == -1)
            {

                marks.Add(mark);
                names.Add(name);


            }

        }

        public string ViewCourseInfo()
        {
            // string[] info = {"Student Name\t\tStudent Mark"};
            string info = "************************************\nStudent Name\tStudent Mark\n";

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length > 6)
                {
                    info += $"{names[i]}\t{marks[i]}\n";

                }
                else
                {

                    info += $"{names[i]}\t\t{marks[i]}\n";
                }
            }

            info += "************************************\n";
            return info;


        }

        public int max()
        {
            int max;
            if (!marks.Any())
            {

                return -1;

            }
            else
            {
                max = marks[0];

                foreach (int mark in marks)
                {
                    if (mark > max)
                    {
                        max = mark;
                    }
                }

                return max;
            }
        }

        public int min()
        {
            int min;
            if (!marks.Any())
            {

                return -1;
            }
            else
            {
                min = marks[0];
                foreach (int mark in marks)
                {
                    if (mark < min)
                    {
                        min = mark;
                    }
                }
            }
            return min;




        }

        public double avg()
        {
            if (!marks.Any()) { return -1; }
            else
            {
                double average; int num = 0;
                for (int i = 0; i < marks.Count; i++)
                {
                    Console.WriteLine($"{marks.Count}");
                  
                    num += marks[i];
                
                }

                average = num / marks.Count;


                return average;
            }



        }

        public int passed()
        {
            int pass;
            if (!marks.Any()) { return -1; }
            else
            {
                pass = 0;
                foreach (int mark in marks)
                {

                    if (mark >= 50)
                    {

                        pass++;



                    }


                }
                return pass;
            }
        }

        public int faild() {
            int faild;
            if (!marks.Any()) { return -1; }
            else
            {
                faild = 0;
                foreach (int mark in marks)
                {

                    if (mark < 50)
                    {

                        faild++;



                    }


                }
                return faild;
            }




        }
    }
}
