using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace lab08
{

    public partial class Form1 : Form
    {
        bool Line, Pie, Bar;  //The flags
        int delta, sum, width = 0, index = 0;
        int[] values = new int[6];
        float[] valuesPie = new float[6];
        Random rand = new Random(); //The random for the colors
        float deltaPie, Point, sumPie; //This one is for the Pie


        private void line_Click(object sender, EventArgs e)
        {

            Line = true; 
            foreach (Control item in groupBox1.Controls) //To check if there is an emprty box to avoid errors
            {
                if (item is TextBox && item.Text == "")
                {
                    MessageBox.Show("One of the text are empty"); //Pop a MessageBox for the user 
                    Line = false;
                    break;
                }
            }

            panel1.Invalidate();

        }

        private void bar_Click(object sender, EventArgs e)
        {
            Bar = true;
            foreach (Control item in groupBox1.Controls) //To check if there is an emprty box to avoid errors
            {
                if (item is TextBox && item.Text == "")
                {
                    MessageBox.Show("One of the text are empty");
                    Bar = false;
                    break;
                }
            }
            panel1.Invalidate();
            
           
            
        }

        public Form1()
        {
            
            InitializeComponent();
        }

        private void pie_Click(object sender, EventArgs e)
        {
            Pie = true; 

            foreach (Control item in groupBox1.Controls) //To check if there is an empty box to avoid errors
            {
                if (item is TextBox && item.Text == "")
                {
                    MessageBox.Show("One of the text are empty");
                    Pie = false;
                    break;
                }
            }
            
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (!Pie && (Line || Bar)) //If the Pie is false and Line or the Bar true then execute the code 
            {
                g.Clear(panel1.BackColor); 
                Pen mypen = new Pen(Color.Black, 3);
                g.DrawLine(mypen, 0, 0, 0, panel1.ClientRectangle.Height); //Draw the Y-axis
                g.DrawLine(mypen, 0, panel1.ClientRectangle.Height, panel1.ClientRectangle.Width, panel1.ClientRectangle.Height); //Draw the X-axis
                X.Visible = true; Y.Visible = true; //Make both X and Y labels visable

                if (Line) //If the flag Line were true then the button Line were clicked on
                {

                    DeltaLineBar(); //Calculate Delta in the fucntions below.
                    DrawLine(mypen, g); //Draw the Lins in the panel
                    Clear(); //Reset every value
                    mypen.Dispose(); //Free the resources
                    g.Dispose(); //Free the resources

                }
                else if(Bar) //If the flag Bar were true then the button Line were clicked on
                {



                    DeltaLineBar(); //Calculate Delta in the fucntions below.

                    SolidBrush myBrush = new SolidBrush(Color.Red);

                    DrawBar(myBrush , g); //Draw the Bar in the panel

                    Clear(); //Reset every value
                    mypen.Dispose();  //Free the resources
                    myBrush.Dispose();
                    g.Dispose();



                }








            }
            else if(Pie) //If the flag Pie were true then the button Line were clicked on
            {
                X.Visible = false; 
                Y.Visible = false;
                SolidBrush myBrush = new SolidBrush(Color.Blue);

                g.Clear(panel1.BackColor);

                DeltaPie(); // Calculate the value of Delta for the Pie
                DrawPie(myBrush, g); // Draw the Pie
                Clear(); //Reset every value
                g.Dispose(); //Free the resources
                myBrush.Dispose();

            }
        }


        private void Clear()
        {
            //This function will avoid any logical error, letting the program to excute more than once
            
            index = 0;
            width = 0;
            sum = 0;
            delta = 0;
            Line = false;
            Pie = false;
            Bar = false;
            sumPie = 0;
            deltaPie = 0;
            Point = 0;
           

        }

       

        private void DeltaLineBar()
        {

            foreach (Control item in groupBox1.Controls) //A loop for every Control in the Groupbox and put it in item
            {
                if (item is TextBox) //If the Control/Item is a Textbox then calculate the sum
                {
                    sum += Convert.ToInt32(item.Text);

                }


            }
            if (sum == 0) { sum = 1; } //If sum = 0 then sum = 1 to avoid any error

            if ((delta = panel1.ClientRectangle.Height / sum) == 0) { delta = 1; } //If Delta = 0 then make delta = 1 to avoid any Logical-Error

            foreach (Control item in groupBox1.Controls) //A loop for every Controler in the groupbox 
            {

                if ((item is TextBox)) //If the iteam/Control a textbox then 
                {
                    //The Tabindex start from 0 to 6 which is the same as the size of the Array.
                    values[item.TabIndex] = delta * Convert.ToInt32(item.Text); //Safe the value inside The Array with the index of The Tabindex of the Textbox
                    values[item.TabIndex] = panel1.ClientRectangle.Height - values[item.TabIndex]; //Subtracting the values with the Panel height in order to start from the buttom

                }
            }




        }

        private void DeltaPie()
        {

            foreach (Control item in groupBox1.Controls) 
            {
                if (item is TextBox)
                {
                    sumPie += float.Parse(item.Text); //Same as before but this time there is a float

                }


            }
            if (sumPie == 0) { sumPie = 1; } //To avoid any error

             deltaPie = 360 / sumPie; 
            

            foreach (Control item in groupBox1.Controls)
            {

                if ((item is TextBox))
                {
                    valuesPie[item.TabIndex] = deltaPie * Convert.ToInt32(item.Text);
                   
                }
            }






        }
        private void DrawLine(Pen mypen , Graphics g)
        {


            mypen.Width = 1; 
            mypen.Color = Color.Blue;
            g.DrawLine(mypen, width, panel1.ClientRectangle.Height, width + 62, values[index]); //Drawing the first line startting from (0,full height) to (62, Value)
            //62 is constant

            for (index = 1; index < values.Length; index++)
            {
                mypen.Color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)); //Generating a random color everytime by using the RBG format
                width += 62; //increasing the constant 
                g.DrawLine(mypen, width, values[index - 1], width + 62, values[index]); //Connecting the two lines together
                values[index - 1] = 0; //Reseting the values

            }
            values[index - 1] = 0;



        }

        private void DrawBar(Brush myBrush , Graphics g)
        {

            Rectangle rect = new Rectangle(15, values[0], 15, panel1.ClientRectangle.Height - values[0]); 
            g.FillRectangle(myBrush, rect); //Drawing the first value
            values[0] = 0;
            for (index = 1; index < values.Length - 1; index++)
            {

                width += 72; //The constant between the Bars
                myBrush = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))); 
                rect = new Rectangle(width, values[index], 15, panel1.ClientRectangle.Height - values[index]); //drawing the first rectangle by subtracting because the points are upside-down
                g.FillRectangle(myBrush, rect);
                values[index] = 0; //Reseting the vlaues of the Bar

            }

            myBrush = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
            rect = new Rectangle(panel1.ClientRectangle.Width - 30, values[5], 15, panel1.ClientRectangle.Height - values[5]);
            g.FillRectangle(myBrush, rect);  //Drawing the last value
            values[5] = 0;





        }

        private void DrawPie(Brush myBrush , Graphics g)
        {
            Rectangle rect = new Rectangle(50, 50, 200, 200);

            Point += valuesPie[0];
            for (index = 1; index < valuesPie.Length ;index++) {
              
               myBrush = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))); //Different color evreytime
                g.FillPie(myBrush, rect, Point, valuesPie[index]); //Drawing the slides
               Point += valuesPie[index]; //Calculating the values in one point for the fill Pie function
               valuesPie[index] = 0; //Resetting the values


            }

            myBrush = new SolidBrush(Color.Blue);
            g.FillPie(myBrush, rect, 0, valuesPie[0]); //Drawing the first color
            valuesPie[0] = 0;

            valuesPie[index - 1] = 0;  //Resetting the values




        }

      

    }
}
