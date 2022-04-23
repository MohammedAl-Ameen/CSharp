using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Lab04
{
    public partial class Form1 : Form
    {

        List<string> contacts = new List<string>();
        int indx = -1;

        private void updateRich() {

            RichBox.Clear();
            foreach(string text in contacts)
            RichBox.Text += text;

            Add_button.Enabled = true;
            delete_button.Visible = true;
            update_button.Visible = true;
            ok_button.Visible = true;

            Contact_Info.Visible = false;
            Search_Text.Clear();

        
        
        }
        public Form1()
        {
            InitializeComponent();
            contacts.Add("Name\t\tAddress\t\tType\t\tMobile\r\n");
            contacts.Add("Ahmad\t\tIrbid\t\tFamily\t\t0777777777\n");
            contacts.Add("Mohammad\tAmman\t\tFriends\t\t0771111111\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateRich();
            //AllocConsole();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {


         
            char[] separators = new char[] { '\t' };
            indx = contacts.FindIndex(a => a.Contains(Search_Text.Text));
            if ((indx != -1) && !(String.IsNullOrEmpty(Search_Text.Text))) {
                

                RichBox.Clear();
             
                RichBox.Text += contacts[indx];
                Add_button.Enabled = false;
                Contact_Info.Visible = true;
                delete_button.Visible = true;
                update_button.Visible = true;
                ok_button.Visible = false;
                
                    string[] sub = contacts[indx].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    name_text.Text = sub[0];
                    city_text.Text = sub[1];
                    type_text.SelectedIndex = type_text.FindStringExact(sub[2]);
                    mobile_text.Text = sub[3];


            }








        }

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Search_Text.Clear();
            updateRich();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
            contacts.RemoveAt(contacts.FindIndex(str => str.Contains(name_text.Text)));
            MessageBox.Show("The operation was done successfully");
            updateRich();
            indx = -1;
        }

        private void update_button_Click(object sender, EventArgs e)
        {




           
            
            contacts[indx] = $"{name_text.Text}\t{city_text.Text}\t\t{type_text.SelectedItem}\t\t{mobile_text.Text}"; //over-ride the indix insted of deleting it, it to the same job as well
            MessageBox.Show("The operation was done successfully");
            updateRich();





        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            name_text.Clear();
            city_text.Clear();
            mobile_text.Clear();
            type_text.ResetText();
            Contact_Info.Visible = true;
            delete_button.Visible = false;
            update_button.Visible = false;
            ok_button.Visible = true;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            contacts.Add($"{name_text.Text}\t\t{city_text.Text}\t\t{type_text.SelectedItem}\t\t{mobile_text.Text}");
            MessageBox.Show("The operation was done successfully");
            updateRich();

        }
    }
}
