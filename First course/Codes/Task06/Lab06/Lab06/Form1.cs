using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab06
{
    public partial class Form1 : Form
    {

        Course course;
        public Form1()
        {
            InitializeComponent();
            course = new Course();
            course.addstudent("Ali", 75);
            course.addstudent("Tamer", 85);
            course.addstudent("Noor", 95);
            course.addstudent("Reema", 55);
            course.addstudent("Mohammed", 99);
            course.addstudent("Murad", 88);
            course.addstudent("Sara", 78);
            course.addstudent("Ahmad", 95);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name.Text) || String.IsNullOrEmpty(Mark.Text))
            {

                MessageBox.Show("On or both of Name and Mark boxes are empty");
                



            }
            else {

                course.addstudent(Name.Text , Convert.ToInt32(Mark.Text));

           

                list.Text += course.ViewCourseInfo();
                if (course.max() != -1) {
                    Max.Text = Convert.ToString(course.max());
                }
                else {
                    Max.Text = "No Max";
                    list.Clear();
                    list.Text =  "There is no studen";
                }

                if (course.min() != -1)
                {
                    Min.Text = Convert.ToString(course.min());
                }
                else
                {
                    Min.Text = "No Min";
                }

                if (course.avg() != -1)
                {
                    avg.Text = Convert.ToString(course.avg());
                }
                else
                {
                    avg.Text = "No Average";
                }

                if (course.passed() != -1)
                {
                    
                    pass.Text = Convert.ToString(course.passed());
                    if (course.passed() == 0) {
                        list.Text += "\n*Note: no one Passed\n\n";

                    }
               
                }
                else
                {
                    pass.Text = "NO Passes";
                   
                }

                if (course.faild() != -1)
                {
                    fall.Text = Convert.ToString(course.faild());
                    if (course.faild() == 0)
                    {
                        list.Text += "\n*Note: no one falid\n\n";
                    }
                }
                else
                {
                    fall.Text = "NO Faild";
                }


              
            
            
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.Text += course.ViewCourseInfo();

            if (course.max() != -1)
            {
                Max.Text = Convert.ToString(course.max());
            }
            else
            {
                Max.Text = "No Max";
                list.Clear();
                list.Text = "There is no students\n";
            }

            if (course.min() != -1)
            {
                Min.Text = Convert.ToString(course.min());
            }
            else
            {
                Min.Text = "No Min";
            }

            if (course.avg() != -1)
            {
                avg.Text = Convert.ToString(course.avg());
            }
            else
            {
                avg.Text = "No Average";
            }

            if (course.passed() != -1)
            {

                pass.Text = Convert.ToString(course.passed());
                if (course.passed() == 0)
                {
                    list.Text += "\n*Note: no one Passed\n\n";

                }

            }
            else
            {
                pass.Text = "NO Passes";

            }

            if (course.faild() != -1)
            {
                fall.Text = Convert.ToString(course.faild());
                if (course.faild() == 0)
                {
                    list.Text += "\n*Note: no one falid\n\n";
                }
            }
            else
            {
                fall.Text = "NO Faild";
            }
        }
    }
}
