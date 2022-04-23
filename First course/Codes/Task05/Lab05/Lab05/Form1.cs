using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace Lab05
{
    public partial class Form1 : Form
    {
        List<string> name = new List<string>();
        List<double> price = new List<double>();
        List<int> amount = new List<int>();
        int indx = -1, choice;
        public Form1()
        {
            InitializeComponent();
          AllocConsole();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                string line = reader.ReadLine();

                char[] separators = new char[] { ' ' };
                string[] sub = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach(string str in sub)
                name.Add(str);

                line = reader.ReadLine();
               
                string[] number = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
               
               
                  
                    foreach (string num in number)
                    {
                        price.Add(Convert.ToDouble(num));
                        amount.Add(0);


                    }
                   

                

              






                line = reader.ReadToEnd();
                separators = new char[] { '\n' };
                sub = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                separators = new char[] { ' ' };
                int counter = 0;
                while (sub.Length != counter)
                {
                         string[] sub1 = sub[counter].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                        indx = name.IndexOf(sub1[0]);
                        
                        int amoun = amount[indx];
                        amoun = Convert.ToInt32(sub1[1]);
                    
                        amount[indx] += amoun;
                   // Console.WriteLine($"{amoun}\t{sub1[0]}\t{sub1[1]}\t{amount[indx]}");
                    counter++;
                    
               

                }


                double total = 0;
                reader.Close();
                richTextBox1.Text = "Name\t\tPrice\t\tAmount\n";
                for (int i = 0; i < name.Count; i++)
                {
                    richTextBox1.Text += $"{name[i]}\t\t{price[i]}\t\t{amount[i]}\n";
                    total += amount[i]*price[i];
                   
                }

                richTextBox1.Text += $"\n \nTotal Sales = {total} JD";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Your don't have to put the .txt");

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName + ".txt");

                

                writer.WriteLine(richTextBox1.Text);

                writer.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void consoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", richTextBox1.Font.Size, richTextBox1.Font.Style);
        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void regularToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Green;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            switch (choice) {

                case 1:
                    pictureBox2.Image = Lab05.Properties.Resources.Sofa;
                    choice = 2;

                    break;

                case 2:
                    pictureBox2.Image = Lab05.Properties.Resources.Table;
                    choice = 3;
                    break;

                case 3:
                    pictureBox2.Image = Lab05.Properties.Resources.Cupboard;
                    choice = 4;
                    break;

                case 4:
                    pictureBox2.Image = Lab05.Properties.Resources.Bed;
                    choice = 1;
                    break;
            
            
            
            }
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 1:
                    pictureBox2.Image = Lab05.Properties.Resources.Cupboard;
                    choice = 4;
                    break;

                case 2:
                    pictureBox2.Image = Lab05.Properties.Resources.Bed;
                    choice = 1;
                    break;

                case 3:
                    pictureBox2.Image = Lab05.Properties.Resources.Sofa;
                    choice = 2;
                    break;

                case 4:
                    pictureBox2.Image = Lab05.Properties.Resources.Table;
                    choice = 3;
                    break;


            }
            }

            private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(1, 5);

            switch (num)
            {

                case 1:
                    pictureBox2.Image = Lab05.Properties.Resources.Bed;
                    choice = 1;
                    break;

                case 2:
                    pictureBox2.Image = Lab05.Properties.Resources.Sofa;
                    choice = 2;
                    break;

                case 3:
                    pictureBox2.Image = Lab05.Properties.Resources.Table;
                    choice = 3;
                    break;

                case 4:
                    pictureBox2.Image = Lab05.Properties.Resources.Cupboard;
                    choice = 4;
                    break;

                   

            }

                
        }
    }
}
