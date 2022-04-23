using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09
{
   
    public partial class Form1 : Form
    {
        bool flag = false;
        Department department = new Department();
        Employee employee;
        int ID = 6;
        public Form1()
        {
            MessageBox.Show("There is already a list");
            list();
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            id.Text = ID.ToString();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administrative")
            {
                type.Text = "Extra Hours:";
                type.Visible = true;
            }
            else if (comboBox1.Text == "Academic")
            {
                type.Text = "No. Courses:";
                type.Visible = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (string.IsNullOrEmpty(item.Text))
                        {
                            flag = true;
                            MessageBox.Show("There is an empty box");
                            break;

                        }

                    }

                }

                if (!flag)
                {


                    if (comboBox1.Text == "Administrative")
                    {
                        employee = new Administrative(Convert.ToInt32(extra.Text), name.Text, Convert.ToInt32(id.Text), Convert.ToDouble(baseSalary.Text));
                        department.addEmployee(employee);
                        ID++;
                        clear();


                    }
                    else if (comboBox1.Text == "Academic")
                    {
                        employee = new Academic(Convert.ToInt32(extra.Text), name.Text, Convert.ToInt32(id.Text), Convert.ToDouble(baseSalary.Text));
                        department.addEmployee(employee);
                        ID++;
                        clear();
                    }


                }
            }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message,"Format Exeption" ,MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            


            string info = department.printEmployeesInfo();
            richTextBox1.Text = info;




        }

        private void clear() {

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }

                if (item is ComboBox) {
                    item.Text = "";
                }

            }
            id.Text = ID.ToString();

            type.Visible = false;


        }

        private void list()
        {

            Employee employee;
            employee = new Academic(6, "Mohammed", 1, 2500);
            department.addEmployee(employee);
            employee = new Administrative(10, "Ali", 2, 325);
            department.addEmployee(employee);
            employee = new Administrative(15, "Emad", 3, 700);
            department.addEmployee(employee);
            employee = new Administrative(5, "Tamer", 4, 400);
            department.addEmployee(employee);
            employee = new Academic(3, "Ahmad", 5, 980);
            department.addEmployee(employee);
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
}
